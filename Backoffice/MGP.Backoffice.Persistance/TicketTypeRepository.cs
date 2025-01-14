using MGP.Backoffice.CrossCutting.Exceptions;
using MGP.Backoffice.Persistance.Data.Tables;
using MGP.Backoffice.Persistance.Interfaces;
using MGP.Backoffice.Persistence.Data.Tables;
using Microsoft.EntityFrameworkCore;

namespace MGP.Backoffice.Persistance;

public class TicketTypeRepository : ITicketTypeRepository
{
    private readonly MyDbContext _dbContext;

    public TicketTypeRepository(MyDbContext myDbContext)
    {
        _dbContext = myDbContext;
    }

    public async Task AddTicketTypeAsync(Guid agentId, List<int> ticketTypeIds, int areaId)
    {

        var newAgentTicketTypes = ticketTypeIds.Select(id => new AgentTicketType
        {
            Id = Guid.NewGuid(),
            AgentId = agentId,
            TicketTypeId = id,
            CreationDate = DateTime.UtcNow
        }).ToList();

        await _dbContext.Set<AgentTicketType>().AddRangeAsync(newAgentTicketTypes);
    }
    public async Task<bool> ValidateAreaAndTicketTypeAsync(List<int> ticketTypeIds, int areaId)
    {
        var validTicketTypes = await _dbContext.Set<TicketType>()
                                               .Where(tt => ticketTypeIds.Contains(tt.Id) && tt.AreaId == areaId)
                                               .Select(tt => tt.Id)
                                               .ToListAsync();

        if (validTicketTypes.Count != ticketTypeIds.Count)
        {
            throw new AreaTicketTypeException();
        }

        return true;
    }

    public async Task<List<TicketType>> GetTicketTypesByUserIdAsync(Guid agentId)
    {
        var ticketTypes = await _dbContext.Set<AgentTicketType>()
            .Where(at => at.AgentId == agentId)
            .Select(at => at.TicketType)
            .ToListAsync();

        if (ticketTypes == null || ticketTypes.Count == 0)
            return new List<TicketType>();

        return ticketTypes;
    }
    public async Task RemoveTicketTypesAsync(Guid agentId)
    {
        var ticketTypes = await _dbContext.Set<AgentTicketType>().Where(a => a.AgentId == agentId).ToListAsync();
        _dbContext.Set<AgentTicketType>().RemoveRange(ticketTypes);
    }
    public async Task<TicketType> FindByNameAsync(string ticketName)
    {
        var ticketType = await _dbContext.Set<TicketType>()
            .Where(a => a.Name.Equals(ticketName))
            .FirstOrDefaultAsync();

        return ticketType == null ? throw new AreaNotFoundException() : ticketType;
    }


}
