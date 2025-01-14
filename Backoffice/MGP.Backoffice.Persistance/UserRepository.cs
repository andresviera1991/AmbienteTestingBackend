using MGP.Backoffice.CrossCutting.Enum;
using MGP.Backoffice.CrossCutting.Exceptions;
using MGP.Backoffice.Persistance.Data.Tables;
using MGP.Backoffice.Persistance.DTOs;
using MGP.Backoffice.Persistance.Interfaces;
using MGP.Backoffice.Persistence.Data.Tables;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
namespace MGP.Backoffice.Persistance;

public class UserRepository : IUserRepository
{
    private readonly MyDbContext _dbContext;
    private readonly object _lock = new();

    public UserRepository(MyDbContext myDbContext)
    {
        _dbContext = myDbContext;
    }

    #region ADD METHODS
    public void AddAgentToQueue(User agent)
    {
        lock (_lock)
        {
            var lastPosition = _dbContext.Set<User>()
                .OrderByDescending(u => u.QueuePosition)
                .FirstOrDefault()?.QueuePosition ?? 0;

            agent.QueuePosition = lastPosition + 1;

            _dbContext.Set<User>().Add(agent);
            _dbContext.SaveChanges();
        }
    }

    #endregion

    #region GET METHODS

    public async Task<User> GetUserAsync(Guid userId)
    {
        return await _dbContext.Set<User>().Where(u => u.Id == userId).Include(u => u.Area).Include(u => u.UserStatus).SingleOrDefaultAsync() ?? throw new NotFoundException();
    }
    public async Task<User> GetUserAsync(string userName)
    {
        return await _dbContext.Set<User>().Where(u => u.UserName == userName).Include(u => u.Area).Include(u => u.UserStatus).SingleOrDefaultAsync() ?? throw new NotFoundException();
    }
    public async Task<User> GetUserbyEmployeeNumberAsync(string employeeNumber)
    {
        return await _dbContext.Set<User>().Where(u => u.EmployeeNumber == employeeNumber).SingleOrDefaultAsync() ?? throw new NotFoundException();
    }
    public async Task<List<User>> GetUsersByRoleAreaAndTicketTypeAsync(Role role, Area area, TicketType ticketType)
    {
        var users = await _dbContext.Set<User>()
            .Where(u => u.AreaId == area.Id)
            .Join(
                _dbContext.Set<IdentityUserRole<Guid>>(),
                user => user.Id,
                userRole => userRole.UserId,
                (user, userRole) => new { user, userRole }
            )
            .Where(joined => joined.userRole.RoleId == role.Id)
            .Join(
                _dbContext.Set<AgentTicketType>(),
                joined => joined.user.Id,
                agentTicket => agentTicket.AgentId,
                (joined, agentTicket) => new { joined.user, agentTicket }
            )
            .Where(joined => joined.agentTicket.TicketTypeId == ticketType.Id)
            .Select(joined => joined.user)
            .ToListAsync();

        return users;
    }
    public Task<User> GetNextAvailableAgentAsync(string ticketTypeDescription, string areaName)
    {
        lock (_lock)
        {
            var areaEntity = _dbContext.Set<Area>().FirstOrDefaultAsync(a => a.Name == areaName).Result ?? throw new AreaNotFoundException();
            var ticketTypeEntity = _dbContext.Set<TicketType>().FirstOrDefaultAsync(tt => tt.Name == ticketTypeDescription && tt.AreaId == areaEntity.Id).Result ?? throw new TicketTypeNotFoundException();

            var agentQueue = _dbContext.Set<User>()
                .Where(u => u.AreaId == areaEntity.Id)
                .OrderBy(u => u.QueuePosition)
                .ToListAsync().Result;

            foreach (var agent in agentQueue)
            {
                if (CanAgentTakeTicket(agent, ticketTypeEntity, areaEntity).Result)
                {
                    MoveAgentToEndOfQueue(agent);
                    return Task.FromResult(agent);
                }
            }

            return Task.FromResult(new User());
        }
    }

    #endregion

    #region LIST METHODS 
    public Task<List<User>> ListAgentsByTicketTypeAsync(int? ticketTypeId)
    {
        return _dbContext.Set<AgentTicketType>().Include(a => a.Agent)
                                                .Where(a => a.Agent.UserStatusId == (int)UserStatusEnum.ACTIVE)
                                                .Where(a => a.TicketTypeId == ticketTypeId)
                                                .Select(a => a.Agent).ToListAsync();
    }
    public async Task<List<User>> ListAgentsByFilters(ListAgentByFiltersData listAgentByFiltersData)
    {
        IQueryable<User> query = _dbContext.Set<User>().Include(u => u.Area).Include(u => u.UserStatus);

        query = FilterByRole(listAgentByFiltersData, query);
        query = FilterByArea(listAgentByFiltersData, query);
        query = FilterByFullName(listAgentByFiltersData, query);
        query = FilterByDocumentNumber(listAgentByFiltersData, query);
        query = FilterByEmployeeNumber(listAgentByFiltersData, query);
        query = FilterByStatus(listAgentByFiltersData, query);

        int skip = (listAgentByFiltersData.PageNumber - 1) * listAgentByFiltersData.PageSize;

        return await query.OrderByDescending(x => x.FirstName).Skip(skip).Take(listAgentByFiltersData.PageSize).ToListAsync();
    }
    private IQueryable<User> FilterByRole(ListAgentByFiltersData listAgentByFiltersData, IQueryable<User> query)
    {
        if (!string.IsNullOrEmpty(listAgentByFiltersData.Role))
        {
            query = query.Where(u =>
                _dbContext.UserRoles
                    .Where(ur => ur.UserId == u.Id)
                    .Join(
                        _dbContext.Roles,
                        userRole => userRole.RoleId,
                        role => role.Id,
                        (userRole, role) => role.Name
                    )
                    .Contains(listAgentByFiltersData.Role)
            );
        }

        return query;
    }
    private static IQueryable<User> FilterByArea(ListAgentByFiltersData listAgentByFiltersData, IQueryable<User> query)
    {
        if (!string.IsNullOrEmpty(listAgentByFiltersData.Area))
        {
            query = query.Where(t => t.Area.Name == listAgentByFiltersData.Area);
        }

        return query;
    }
    private static IQueryable<User> FilterByFullName(ListAgentByFiltersData listAgentByFiltersData, IQueryable<User> query)
    {
        if (!string.IsNullOrEmpty(listAgentByFiltersData.FullName))
        {
            var fullNameParts = listAgentByFiltersData.FullName.ToLower().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var part in fullNameParts)
            {
                query = query.Where(u =>
                    u.FirstName.ToLower().Contains(part) ||
                    u.LastName.ToLower().Contains(part)
                );
            }
        }

        return query;
    }
    private static IQueryable<User> FilterByDocumentNumber(ListAgentByFiltersData listAgentByFiltersData, IQueryable<User> query)
    {
        if (!string.IsNullOrEmpty(listAgentByFiltersData.DocumentNumber))
        {
            query = query.Where(t => t.DocumentNumber == listAgentByFiltersData.DocumentNumber);
        }

        return query;
    }
    private static IQueryable<User> FilterByEmployeeNumber(ListAgentByFiltersData listAgentByFiltersData, IQueryable<User> query)
    {
        if (!string.IsNullOrEmpty(listAgentByFiltersData.EmployeeNumber))
        {
            query = query.Where(t => t.EmployeeNumber == listAgentByFiltersData.EmployeeNumber);
        }

        return query;
    }
    private static IQueryable<User> FilterByStatus(ListAgentByFiltersData listAgentByFiltersData, IQueryable<User> query)
    {
        if (listAgentByFiltersData.UserStatusId != null)
        {
            query = query.Where(t => t.UserStatusId == listAgentByFiltersData.UserStatusId);
        }

        return query;
    }
    #endregion

    #region UPDATE METHODS
    private void MoveAgentToEndOfQueue(User agent)
    {
        lock (_lock)
        {
            var lastPosition = _dbContext.Set<User>()
                .OrderByDescending(u => u.QueuePosition)
                .FirstOrDefault()?.QueuePosition ?? 0;

            agent.QueuePosition = lastPosition + 1;

            _dbContext.SaveChanges();
        }
    }

    #endregion

    #region VALIDATE METHODS
    private async Task<bool> CanAgentTakeTicket(User agent, TicketType ticketType, Area area)
    {
        Guid agentRoleId = new Guid("00000000-0000-0000-0000-000000000002");

        var hasAgentRole = await _dbContext.Set<IdentityUserRole<Guid>>()
            .AnyAsync(ur => ur.UserId == agent.Id && ur.RoleId == agentRoleId);

        var canTakeTicket = agent.AreaId == area.Id &&
                            await _dbContext.Set<AgentTicketType>()
                                .AnyAsync(agt => agt.AgentId == agent.Id && agt.TicketTypeId == ticketType.Id);

        return hasAgentRole && canTakeTicket;
    }

    #endregion

}
