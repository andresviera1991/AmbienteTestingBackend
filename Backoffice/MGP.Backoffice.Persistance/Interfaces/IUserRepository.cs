using MGP.Backoffice.Persistance.Data.Tables;
using MGP.Backoffice.Persistance.DTOs;
using MGP.Backoffice.Persistence.Data.Tables;

namespace MGP.Backoffice.Persistance.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetUserAsync(string userName);
        Task<User> GetUserAsync(Guid userId);
        Task<User> GetUserbyEmployeeNumberAsync(string employeeNumber);
        Task<List<User>> GetUsersByRoleAreaAndTicketTypeAsync(Role role, Area area, TicketType ticketType);
        Task<User> GetNextAvailableAgentAsync(string ticketTypeDescription, string areaName);
        Task<List<User>> ListAgentsByFilters(ListAgentByFiltersData listAgentByFiltersData);
        Task<List<User>> ListAgentsByTicketTypeAsync(int? ticketTypeId);
    }
}
