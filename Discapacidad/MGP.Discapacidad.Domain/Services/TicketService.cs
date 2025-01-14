using AutoMapper;
using MGP.Discapacidad.CrossCutting.Excepciones;
using MGP.Discapacidad.Domain.interfaces;
using MGP.Discapacidad.Persistance.Data.Tables;
using MGP.Discapacidad.Persistance.DTOs;
using MGP.Discapacidad.Persistance.DTOs.Ticket;
using MGP.Discapacidad.Persistance.Interface;
using System;
using System.Threading.Tasks;
using JsonSerializer = System.Text.Json.JsonSerializer;
using MGP.Discapacidad.CrossCutting.Enum;
using System.Collections.Generic;
using MGP.Discapacidad.Client.Interface.Backoffice;
using MGP.Discapacidad.Client.Interface.Authentication;
namespace MGP.Discapacidad.Domain.Services;

public class TicketService : ITicketService
{
    private readonly IDocumentService _documentService;
    private readonly ITicketRepository _ticketRepository;
    private readonly IMapper _mapper;
    private readonly IAuditService _auditService;
    private readonly INotificationService _notificationService;
    private readonly IEmailService _emailService;
    private readonly IAuthenticationClient _authenticationClient;
    private readonly IBackofficeClient _backofficeClient;
    private const string CUD = "CUD";
    private const string SUBE = "SUBE";
    private const string PARKING = "PARKING";

    public TicketService(ITicketRepository TicketRepository,
                         IDocumentService documentService,
                         IMapper mapper,
                         IAuditService auditService,
                         INotificationService notificationService,
                         IEmailService emailService,
                         IBackofficeClient backofficeClient,
                         IAuthenticationClient authenticationClient)
    {
        _ticketRepository = TicketRepository;
        _documentService = documentService;
        _mapper = mapper;
        _auditService = auditService;
        _notificationService = notificationService;
        _emailService = emailService;
        _backofficeClient = backofficeClient;
        _authenticationClient = authenticationClient;
    }

    #region CREATE TICKETS METHODS

    public async Task<CreateTicketCudData> CreateTicketCudAsync(CreateTicketCudData ticketCudData)
    {
        if (await _ticketRepository.TicketOpenExistAsync(ticketCudData.UserId, TicketTypeEnum.CUD))
        {
            throw new TicketAlreadyOpenException();
        }

        ticketCudData.Documents = await _documentService.UploadImageAsync(ticketCudData.Documents);
        ticketCudData.AgentId = await _backofficeClient.GetNextAvailableAgentAsync(CUD);
        ticketCudData.AssignedAgentId = ticketCudData.AgentId;

        Ticket ticket = await _ticketRepository.CreateTicketCudAsync(ticketCudData);

        await SendEmailCreateTicket(ticketCudData.Email, $"Solicitud de CUD - Código: {ticket.TicketCode}", EmailTemplateEnum.CREATE_CUD);
        await SendAudit(ticket, CUD);

        return _mapper.Map<CreateTicketCudData>(ticket);
    }

    public async Task<CreateTicketSubeData> CreateTicketSubeAsync(CreateTicketSubeData ticketSubeData)
    {
        if (await _ticketRepository.TicketOpenExistAsync(ticketSubeData.UserId, TicketTypeEnum.SUBE))
        {
            throw new TicketAlreadyOpenException();
        }

        ticketSubeData.Documents = await _documentService.UploadImageAsync(ticketSubeData.Documents);
        ticketSubeData.AgentId = await _backofficeClient.GetNextAvailableAgentAsync(SUBE);
        ticketSubeData.AssignedAgentId = ticketSubeData.AgentId;
        ticketSubeData.CudExpirationDate = ticketSubeData.CudExpirationDate.ToLocalTime().ToUniversalTime();
        Ticket ticket = await _ticketRepository.CreateTicketSubeAsync(ticketSubeData);

        await SendEmailCreateTicket(ticketSubeData.Email, $"Solicitud de SUBE - Código: {ticket.TicketCode}", EmailTemplateEnum.CREATE_SUBE);
        await SendAudit(ticket, SUBE);

        return _mapper.Map<CreateTicketSubeData>(ticket);
    }

    public async Task<CreateTicketParkingData> CreateTicketParkingAsync(CreateTicketParkingData ticketParkingData)
    {
        if (await _ticketRepository.TicketOpenExistAsync(ticketParkingData.UserId, TicketTypeEnum.PARKING))
        {
            throw new TicketAlreadyOpenException();
        }

        ticketParkingData.Documents = await _documentService.UploadImageAsync(ticketParkingData.Documents);
        ticketParkingData.AgentId = await _backofficeClient.GetNextAvailableAgentAsync(PARKING);
        ticketParkingData.AssignedAgentId = ticketParkingData.AgentId;

        Ticket ticket = await _ticketRepository.CreateTicketParkingAsync(ticketParkingData);

        await SendEmailCreateTicket(ticketParkingData.Email, $"Solicitud de Estacionamiento - Código: {ticket.TicketCode}", EmailTemplateEnum.CREATE_PARKING);
        await SendAudit(ticket, PARKING);

        return _mapper.Map<CreateTicketParkingData>(ticket);
    }

    #endregion

    #region GET TICKET METHODS
    public async Task<GetTicketCudData> GetTicketCudUserAsync(Guid userId, Guid? ticketId, string ticketCode)
    {
        TicketCud ticket = await _ticketRepository.GetTicketCudUserAsync(userId, ticketId, ticketCode);
        GetTicketCudData getTicketCudData = _mapper.Map<GetTicketCudData>(ticket);

        getTicketCudData.Ticket.UserData = await _authenticationClient.GetUserDataAsync(getTicketCudData.Ticket.UserId);

        if (getTicketCudData.Ticket.AssignedAgentId != null)
        {
            getTicketCudData.Ticket.AgentData = await _backofficeClient.GetAgentDataAsync(getTicketCudData.Ticket.AssignedAgentId.Value);
        }

        return getTicketCudData;
    }

    public async Task<GetTicketSubeData> GetTicketSubeUserAsync(Guid userId, Guid? ticketId, string ticketCode)
    {
        TicketSube ticket = await _ticketRepository.GetTicketSubeUserAsync(userId, ticketId, ticketCode);
        GetTicketSubeData getTicketSubeData = _mapper.Map<GetTicketSubeData>(ticket);
        getTicketSubeData.Ticket.UserData = await _authenticationClient.GetUserDataAsync(getTicketSubeData.Ticket.UserId);

        if (getTicketSubeData.Ticket.AssignedAgentId != null)
        {
            getTicketSubeData.Ticket.AgentData = await _backofficeClient.GetAgentDataAsync(getTicketSubeData.Ticket.AssignedAgentId.Value);
        }

        return getTicketSubeData;
    }

    public async Task<GetTicketParkingData> GetTicketParkingUserAsync(Guid userId, Guid? ticketId, string ticketCode)
    {
        TicketParking ticket = await _ticketRepository.GetTicketParkingUserAsync(userId, ticketId, ticketCode);
        GetTicketParkingData getTicketParkingData = _mapper.Map<GetTicketParkingData>(ticket);
        getTicketParkingData.Ticket.UserData = await _authenticationClient.GetUserDataAsync(getTicketParkingData.Ticket.UserId);

        if (getTicketParkingData.Ticket.AssignedAgentId != null)
        {
            getTicketParkingData.Ticket.AgentData = await _backofficeClient.GetAgentDataAsync(getTicketParkingData.Ticket.AssignedAgentId.Value);
        }
        return getTicketParkingData;
    }

    #region GET TICKET METHODS (AGENT)

    public async Task<GetTicketCudData> GetTicketCudAgentAsync(Guid ticketId, string ticketCode)
    {
        TicketCud ticket = await _ticketRepository.GetTicketCudAgentAsync(ticketId, ticketCode);
        GetTicketCudData getTicketCudData = _mapper.Map<GetTicketCudData>(ticket);
        getTicketCudData.Ticket.UserData = await _authenticationClient.GetUserDataAsync(getTicketCudData.Ticket.UserId);

        if (getTicketCudData.Ticket.AssignedAgentId != null)
        {
            getTicketCudData.Ticket.AgentData = await _backofficeClient.GetAgentDataAsync(getTicketCudData.Ticket.AssignedAgentId.Value);
        }
        return getTicketCudData;
    }

    public async Task<GetTicketSubeData> GetTicketSubeAgentAsync(Guid ticketId, string ticketCode)
    {
        TicketSube ticket = await _ticketRepository.GetTicketSubeAgentAsync(ticketId, ticketCode);
        GetTicketSubeData getTicketSubeData = _mapper.Map<GetTicketSubeData>(ticket);
        getTicketSubeData.Ticket.UserData = await _authenticationClient.GetUserDataAsync(getTicketSubeData.Ticket.UserId);
        if (getTicketSubeData.Ticket.AssignedAgentId != null)
        {
            getTicketSubeData.Ticket.AgentData = await _backofficeClient.GetAgentDataAsync(getTicketSubeData.Ticket.AssignedAgentId.Value);
        }
        return getTicketSubeData;
    }

    public async Task<GetTicketParkingData> GetTicketParkingAgentAsync(Guid ticketId, string ticketCode)
    {
        TicketParking ticket = await _ticketRepository.GetTicketParkingAgentAsync(ticketId, ticketCode);
        GetTicketParkingData getTicketParkingData = _mapper.Map<GetTicketParkingData>(ticket);
        getTicketParkingData.Ticket.UserData = await _authenticationClient.GetUserDataAsync(getTicketParkingData.Ticket.UserId);

        if (getTicketParkingData.Ticket.AssignedAgentId != null)
        {
            getTicketParkingData.Ticket.AgentData = await _backofficeClient.GetAgentDataAsync(getTicketParkingData.Ticket.AssignedAgentId.Value);
        }
        return getTicketParkingData;
    }

    #endregion

    #endregion

    #region LIST TICKETS METHOD

    public async Task<ListTicketData[]> ListTicketsUserAsync(Guid userId)
    {
        var listTicketData = _mapper.Map<ListTicketData[]>(await _ticketRepository.ListTicketsAsync(userId));

        foreach (var ticketData in listTicketData)
        {
            ticketData.UserData = await _authenticationClient.GetUserDataAsync(ticketData.UserId);
            ticketData.AgentData = await _backofficeClient.GetAgentDataAsync(ticketData.AssignedAgentId);
        }

        return listTicketData;
    }

    public async Task<ListTicketData[]> ListTicketAgentAsync(ListTicketFiltersDto listTicketFiltersDto)
    {
        var listTicketData = _mapper.Map<ListTicketData[]>(await _ticketRepository.ListTicketsAsync(listTicketFiltersDto.AgentId,
                                                                                      listTicketFiltersDto.TicketTypeId,
                                                                                      listTicketFiltersDto.TicketStatusId,
                                                                                      listTicketFiltersDto.PageSize,
                                                                                      listTicketFiltersDto.PageNumber,
                                                                                      listTicketFiltersDto.UserIds,
                                                                                      listTicketFiltersDto.TicketCode));

        foreach (var ticketData in listTicketData)
        {
            ticketData.UserData = await _authenticationClient.GetUserDataAsync(ticketData.UserId);
            ticketData.AgentData = await _backofficeClient.GetAgentDataAsync(ticketData.AssignedAgentId);
        }

        return listTicketData;
    }

    public async Task<List<CountTicketByAgentData>> CountTicketByAgentAsync()
    {
        var countTicketByAgent = await _ticketRepository.CountTicketByAgentAsync();

        foreach (var group in countTicketByAgent)
        {
            group.Agent = await _backofficeClient.GetAgentDataAsync(group.AgentId);
        }

        return countTicketByAgent;
    }

    public async Task<int> CountTicketsByfilterAsync(ListTicketFiltersDto listTicketFiltersDto)
    {
        return await _ticketRepository.CountTicketsByFiltersAsync(listTicketFiltersDto.AgentId,
                                                                  listTicketFiltersDto.TicketTypeId,
                                                                  listTicketFiltersDto.TicketStatusId,
                                                                  listTicketFiltersDto.PageSize,
                                                                  listTicketFiltersDto.PageNumber,
                                                                  listTicketFiltersDto.UserIds,
                                                                  listTicketFiltersDto.TicketCode);
    }

    #endregion

    #region UPDATE METHODS
    public async Task UpdateTicketCudAsync(UpdateTicketCudData updateTicketCudData)
    {
        if (updateTicketCudData.MedicalCommitteDate.HasValue && updateTicketCudData.MedicalCommitteDate.Value.Date <= DateTime.Today)
        {
            throw new InvalidMedicalCommitteDateException();
        }

        TicketCud ticketCud = await _ticketRepository.UpdateTicketCudAsync(updateTicketCudData);

        await SendEmailUpdateTicket(updateTicketCudData.UserEmail, $"Hay novedades en tu ticket {ticketCud.Ticket.TicketCode}", EmailTemplateEnum.NEW_TICKET_ACTIVITY);
        await SendNotification(ticketCud.Ticket.UserId, ticketCud.Ticket.TicketCode);
    }
    public async Task UpdateTicketSubeAsync(UpdateTicketSubeData updateTicketSubeData)
    {

        TicketSube ticketSube = await _ticketRepository.UpdateTicketSubeAsync(updateTicketSubeData);
        await SendEmailUpdateTicket(updateTicketSubeData.UserEmail, $"Hay novedades en tu ticket {ticketSube.Ticket.TicketCode}", EmailTemplateEnum.NEW_TICKET_ACTIVITY);
        await SendNotification(ticketSube.Ticket.UserId, ticketSube.Ticket.TicketCode);
    }
    public async Task UpdateTicketParkingAsync(UpdateTicketParkingData updateTicketParkingData)
    {
        TicketParking ticketParking = await _ticketRepository.UpdateTicketParkingAsync(updateTicketParkingData);

        await SendEmailUpdateTicket(updateTicketParkingData.UserEmail, $"Hay novedades en tu ticket {ticketParking.Ticket.TicketCode}", EmailTemplateEnum.NEW_TICKET_ACTIVITY);
        await SendNotification(ticketParking.Ticket.UserId, ticketParking.Ticket.TicketCode);
    }
    public async Task UpdateAllTicketStatusesAsync(Guid userId, int ticketStatusId)
    {
        await _ticketRepository.UpdateAllTicketStatusesAsync(userId, ticketStatusId);
    }
    public async Task UpdateAgentAssignedAsync(Guid agentId, List<string> backupAgentList)
    {
        await _ticketRepository.UpdateAgentAssignedAsync(agentId, backupAgentList);
    }
    public async Task CancelTicketAsync(Guid userId, Guid ticketId)
    {
        await _ticketRepository.CancelTicket(userId, ticketId);
    }
    public async Task ReassignTicketAsync(Guid agentId)
    {
        List<Ticket> tickets = await _ticketRepository.ListTicketAssigned(agentId);

        foreach (Ticket ticket in tickets)
        {
            var nextAgentId = await _backofficeClient.GetNextAvailableAgentAsync(ticket.TicketType.Name);
            ticket.AssignedAgentId = nextAgentId;
            ticket.AgentId = nextAgentId;
        }

        await _ticketRepository.SaveChangesAsync(tickets);
    }
    public async Task ReassignTicketAsync(Guid ticketId, Guid agentId, Guid supervisorId)
    {
        await _ticketRepository.ReassignTicketAsync(ticketId, agentId);
    }

    #endregion

    #region PRIVATE METHODS

    private async Task SendEmailCreateTicket(string email, string subject, EmailTemplateEnum template)
    {
        if (!string.IsNullOrEmpty(email))
        {
            var bodyEmail = await _emailService.GetEmailTemplateAsync(template);
            await _emailService.SendEmailHandlerAsync(email, subject, bodyEmail);
        }
    }
    private async Task SendAudit(Ticket ticket, string ticketType)
    {
        await _auditService.SendAudit(new AuditData(
            ticket.UserId,
            "POST",
            ticketType,
            ticket.Id.ToString(),
            "",
            JsonSerializer.Serialize(ticket)
        ));
    }
    private async Task SendEmailUpdateTicket(string email, string subject, EmailTemplateEnum template)
    {
        if (!string.IsNullOrEmpty(email))
        {
            var bodyEmail = await _emailService.GetEmailTemplateAsync(template);
            await _emailService.SendEmailHandlerAsync(email, subject, bodyEmail);
        }
    }
    private async Task SendNotification(Guid userId, string ticketCode)
    {
        await _notificationService.SendNotification(new NotificationData(
                    userId, "El Ticket " + ticketCode + " ha sido actualizado", "", 1
        ));
    }

    #endregion

    #region VALIDATE METHODS
    public async Task<bool> TicketExitsAsync(Guid ticketId)
    {
        return await _ticketRepository.TicketExistAsync(ticketId);
    }

    #endregion
}
