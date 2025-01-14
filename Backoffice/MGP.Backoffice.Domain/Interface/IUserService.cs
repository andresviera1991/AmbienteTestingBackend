using MGP.Backoffice.Domain.DTOs;
using MGP.Backoffice.Persistance.DTOs;

namespace MGP.Backoffice.Domain.Interface;

public interface IUserService
{
    Task<bool> RegisterAsync(RegisterRequestData registerRequestData);
    Task<List<UserData>> ListAgentsByFilters(ListAgentByFiltersData listAgentByFiltersData);
    Task<UserData> GetUserByIdAsync(Guid id);
    Task AssignTicketsToUsersFromLeaveAsync();
    Task<UserData> NextAvailableAgent(string TicketType, string Area);
    Task UpdateAgentAync(UpdateAgentData updateAgentData);
    Task<List<FullNameData>> ListAgentsByTicketTypeAsync(int? ticketTypeId);
}
