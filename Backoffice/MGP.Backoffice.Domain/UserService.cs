using AutoMapper;
using Confluent.Kafka;
using MGP.Backoffice.CrossCutting.Enum;
using MGP.Backoffice.CrossCutting.Exceptions;
using MGP.Backoffice.Domain.DTOs;
using MGP.Backoffice.Domain.Interface;
using MGP.Backoffice.Domain.Interfaces;
using MGP.Backoffice.Persistance.Data.Tables;
using MGP.Backoffice.Persistance.DTOs;
using MGP.Backoffice.Persistance.Interfaces;
using MGP.Backoffice.Persistence.Data.Tables;
using Microsoft.AspNetCore.Identity;
using System.Text.Json;
namespace MGP.Backoffice.Domain;

public class UserService : IUserService
{
    private readonly UserManager<User> _userManager;
    private readonly RoleManager<Role> _roleManager;
    private readonly IUserRepository _userRepository;
    private readonly IAreaRepository _areaRepository;
    private readonly ITicketTypeRepository _agentTicketTypeRepository;
    private readonly IAgentLeaveRepository _agentLeaveRepository;
    private readonly IMapper _mapper;
    private readonly IEmailService _emailService;
    private readonly IAuditService _auditService;
    private readonly IProducer<Null, string> _producer;

    public const int DISCAPACIDAD = 1;
    public const string AGENTE = "AGENTE";

    public UserService(UserManager<User> userManager,
                       RoleManager<Role> roleManager,
                       IUserRepository userRepository,
                       IAreaRepository areaRepository,
                       IAgentLeaveRepository agentLeaveRepository,
                       ITicketTypeRepository agentTicketTypeRepository,
                       IMapper mapper,
                       IEmailService emailService,
                       IProducer<Null, string> producer,
                       IAuditService auditService)
    {
        _userManager = userManager;
        _roleManager = roleManager;
        _areaRepository = areaRepository;
        _userRepository = userRepository;
        _agentTicketTypeRepository = agentTicketTypeRepository;
        _agentLeaveRepository = agentLeaveRepository;
        _mapper = mapper;
        _emailService = emailService;
        _producer = producer;
        _auditService = auditService;
    }

    #region REGISTER
    public async Task<bool> RegisterAsync(RegisterRequestData registerRequestData)
    {
        Area area = await _areaRepository.FindByIdAsync(registerRequestData.AreaId) ?? throw new AreaNotFoundException();
        Role role = await _roleManager.FindByNameAsync(registerRequestData.Role) ?? throw new RoleNotFoundException();

        var ticketTypeIds = registerRequestData.ManagedTicketTypes.Select(tt => tt.Id).ToList();
        bool isValid = await _agentTicketTypeRepository.ValidateAreaAndTicketTypeAsync(ticketTypeIds, area.Id);

        if (isValid)
        {
            var user = _mapper.Map<User>(registerRequestData);
            user.Id = Guid.NewGuid();
            user.AreaId = area.Id;
            user.UserStatusId = (int)UserStatusEnum.ACCESS_REQUESTED;
            user.CreationDate = DateTime.UtcNow;
            var result = await _userManager.CreateAsync(user);

            if (!result.Succeeded)
            {
                throw new RegisterException(result.Errors);
            }
            await _userManager.AddToRoleAsync(user, role.Name);
            await _agentTicketTypeRepository.AddTicketTypeAsync(user.Id, ticketTypeIds, area.Id);
            await SendEmailToAdminUsers(registerRequestData);

            await _auditService.SendAudit(new AuditData(
                user.Id,
                "POST",
                "User",
                user.Id.ToString(),
                "",
                JsonSerializer.Serialize(result)
            ));
            return result.Succeeded;

        }
        return false;
    }

    private async Task SendEmailToAdminUsers(RegisterRequestData registerRequestData)
    {
        var bodyEmail = (await _emailService.GetEmailTemplateAsync(EmailTemplateEnum.ACCESS_REQUEST))
                                            .Replace("{firstName}", registerRequestData.FirstName)
                                            .Replace("{lastName}", registerRequestData.LastName)
                                            .Replace("{employeeNumber}", registerRequestData.EmployeeNumber);

        var users = await _userManager.GetUsersInRoleAsync("ADMIN");

        foreach (var user in users)
        {
            await _emailService.SendEmailAsync(user.Email, "Solicitud de Acceso a MDQ Digital", bodyEmail);
        }
    }

    #endregion

    #region GET METHODS
    public async Task<List<UserData>> ListAgentsByFilters(ListAgentByFiltersData listAgentByFiltersData)
    {
        return _mapper.Map<List<UserData>>(await _userRepository.ListAgentsByFilters(listAgentByFiltersData));

    }
    public async Task<List<FullNameData>> ListAgentsByTicketTypeAsync(int? ticketTypeId)
    {
        return _mapper.Map<List<FullNameData>>(await _userRepository.ListAgentsByTicketTypeAsync(ticketTypeId));
    }
    public async Task<List<UserData>> GetUsersBackupAsync(string area, string roleName, string ticketType)
    {
        var role = await _roleManager.FindByNameAsync(roleName);
        if (role == null)
            return null;

        var userArea = await _areaRepository.FindByNameAsync(area);
        if (userArea == null)
            return null;

        var userTicketType = await _agentTicketTypeRepository.FindByNameAsync(ticketType);
        if (ticketType == null)
            return null;

        var users = await _userRepository.GetUsersByRoleAreaAndTicketTypeAsync(role, userArea, userTicketType);
        return _mapper.Map<List<UserData>>(users);
    }
    public async Task<UserData> GetUserByIdAsync(Guid id)
    {
        var agent = await _userRepository.GetUserAsync(id) ?? throw new NotFoundException();
        var ticketTypes = await _agentTicketTypeRepository.GetTicketTypesByUserIdAsync(agent.Id);
        var userData = _mapper.Map<UserData>(agent);
        var roles = await _userManager.GetRolesAsync(agent);
        userData.Roles = roles.FirstOrDefault();
        userData.ManagedTicketTypes = _mapper.Map<List<TicketTypeData>>(ticketTypes);
        return userData;
    }

    #endregion

    #region UPDATE METHODS
    public async Task UpdateAgentAync(UpdateAgentData updateAgentData)
    {
        bool shouldUnassign = false;
        var user = await _userManager.FindByIdAsync(updateAgentData.AgentId.ToString()) ?? throw new NotFoundException();
        user.ModifiedDate = DateTime.UtcNow.AddHours(-3);
        
        //1) ATUALIZAR DATOS DEL USUARIO
        await UpdatePersonInformation(updateAgentData, user);

        //1) MODIFICAR EL ESTADO DEL USUARIO
        await ChangeStatusValidator(updateAgentData, user);

        //2) ACTUALIZO EL AREA
        shouldUnassign = await UpdateAreaAsync(updateAgentData, shouldUnassign, user);

        //3) ACTUALIZO EL ROL
        shouldUnassign = await UpdateRole(updateAgentData, shouldUnassign, user);

        //4) SI ALGUNA DE LAS DOS CONDICIONES ANTERIORES FUE TRUE REMUEVO LOS TICKET TYPES. 
        if (shouldUnassign)
        {
            await UnassignTicketsFromAreaAsync(user.Id);
        }
        var userUpdated = await _userManager.UpdateAsync(user);

        await _auditService.SendAudit(new AuditData(
                user.Id,
                "PUT",
                "User",
                user.Id.ToString(),
                JsonSerializer.Serialize(user),
                JsonSerializer.Serialize(userUpdated)
            ));
    }
    private async Task<UpdateAgentData> ChangeStatusValidator(UpdateAgentData updateAgentData, User user)
    {

        if (user.UserStatusId == (int)UserStatusEnum.ACCESS_REQUESTED && updateAgentData.UserStatusId == (int)UserStatusEnum.ACTIVE ||
            user.UserStatusId == (int)UserStatusEnum.PASSWORD_RESET_REQUESTED && updateAgentData.UserStatusId == (int)UserStatusEnum.ACTIVE)
        {
            Guid password = Guid.NewGuid();
            await _userManager.RemovePasswordAsync(user);
            var passwordResult = await _userManager.AddPasswordAsync(user, password.ToString());

            if (passwordResult.Succeeded)
            {
                user.UserStatusId = (int)UserStatusEnum.ACTIVE;
                var bodyHtml = (await _emailService.GetEmailTemplateAsync(EmailTemplateEnum.SEND_CREDENTIALS))
                                                   .Replace("{userName}", user.UserName)
                                                   .Replace("{password}", password.ToString());

                await _emailService.SendEmailAsync(user.Email, "Creación de Usuario", bodyHtml);

            }
        }
        user.UserStatusId = updateAgentData.UserStatusId;
        return updateAgentData;
    }
    private async Task<bool> UpdateAreaAsync(UpdateAgentData updateAgentData, bool shouldUnassign, User user)
    {
        if (user.AreaId != updateAgentData.AreaId)
        {
            var area = await _areaRepository.FindByIdAsync(updateAgentData.AreaId);
            user.AreaId = area.Id;
            shouldUnassign = true;
        }

        return shouldUnassign;
    }
    private async Task<bool> UpdateRole(UpdateAgentData updateAgentData, bool shouldUnassign, User user)
    {
        var roles = await _userManager.GetRolesAsync(user);

        if (updateAgentData.Role == "ADMIN")
        {
            user.AreaId = null;
            await _agentTicketTypeRepository.RemoveTicketTypesAsync(user.Id);
            shouldUnassign = true;
        }

        if (updateAgentData.Role == "SUPERVISOR")
        {
            shouldUnassign = true;
            await _agentTicketTypeRepository.RemoveTicketTypesAsync(user.Id);
        }

        if (updateAgentData.Role == "AGENTE")
        {
            await _agentTicketTypeRepository.RemoveTicketTypesAsync(user.Id);
            var ticketTypeIds = updateAgentData.ManagedTicketTypes.Select(tt => tt.Id).ToList();
            await _agentTicketTypeRepository.AddTicketTypeAsync(user.Id, ticketTypeIds, updateAgentData.AreaId);
        }

        if (!roles.Contains(updateAgentData.Role))
        {
            await _userManager.RemoveFromRolesAsync(user, roles);
            var role = await _roleManager.FindByNameAsync(updateAgentData.Role) ?? throw new RoleNotFoundException();
            await _userManager.AddToRoleAsync(user, role.Name);
            shouldUnassign = true;
        }

        return shouldUnassign;
    }
    private async Task UnassignTicketsFromAreaAsync(Guid userId)
    {
        await _producer.ProduceAsync("unassign-ticket", new Message<Null, string>
        {
            Value = JsonSerializer.Serialize(new { UserId = userId })
        });
    }
    private async Task UpdatePersonInformation(UpdateAgentData updateAgentData, User user)
    {
        user.EmployeeNumber = updateAgentData.EmployeeNumber;
        user.Email = updateAgentData.Email;
        user.FirstName = updateAgentData.FirstName;
        user.LastName = updateAgentData.LastName;
        user.UserName = updateAgentData.UserName;

        var result = await _userManager.UpdateAsync(user);

        if (!result.Succeeded)
        {
            throw new RegisterException(result.Errors);
        }
    }
    #endregion

    public async Task AssignTicketsToUsersFromLeaveAsync()
    {
        var agentsLeave = await _agentLeaveRepository.FindByStartDateOrEndDateAsync();

        try
        {
            foreach (var agentLeave in agentsLeave)
            {
                var role = await _userManager.GetRolesAsync(agentLeave.Agent);
                if (role.Contains(AGENTE))
                {
                    var types = await _agentTicketTypeRepository.GetTicketTypesByUserIdAsync(agentLeave.Agent.Id);
                    foreach (var type in types)
                    {
                        var agents = await GetUsersBackupAsync(agentLeave.Agent.Area.Name, AGENTE, type.Name);
                        var agentIds = agents.Select(a => a.Id.ToString()).ToList();

                        if (agentLeave.Agent.AreaId == DISCAPACIDAD)
                        {
                            var backupAgentList = DateTime.UtcNow.Date == agentLeave.EndDate.Date
                                ? new List<string> { agentLeave.AgentId.ToString() }
                                : agentIds;

                            await _producer.ProduceAsync("discapacidad-agent-leave", new Message<Null, string>
                            {
                                Value = JsonSerializer.Serialize(
                                    new
                                    {
                                        agentLeave.AgentId,
                                        BackupAgentList = backupAgentList
                                    })
                            });
                        }
                    }
                }
            }
        }
        finally
        {
            _producer.Flush(TimeSpan.FromSeconds(10));
        }
    }

    public async Task<UserData> NextAvailableAgent(string TicketType, string Area)
    {
        return _mapper.Map<UserData>(await _userRepository.GetNextAvailableAgentAsync(TicketType, Area));
    }
}