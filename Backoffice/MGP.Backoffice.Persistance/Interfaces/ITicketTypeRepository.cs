using MGP.Backoffice.Persistance.Data.Tables;
namespace MGP.Backoffice.Persistance.Interfaces;

public interface ITicketTypeRepository
{
    Task AddTicketTypeAsync(Guid agentId, List<int> ticketTypeIds, int areaId);
    Task<TicketType> FindByNameAsync(string ticketName);
    Task<List<TicketType>> GetTicketTypesByUserIdAsync(Guid agentId);
    Task RemoveTicketTypesAsync(Guid agentId);
    Task<bool> ValidateAreaAndTicketTypeAsync(List<int> ticketTypeIds, int areaId);
}
