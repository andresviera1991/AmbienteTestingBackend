using MGP.MisTramites.Client.DTOs.Request;
using MGP.MisTramites.Client.DTOs.Response.ListTicket;
using MGP.MisTramites.Domain.DTOs;
namespace MGP.MisTramites.Domain.Interfaces;
public interface ITicketService
{
    Task<object> GetTicketAgentAsync(string serviceName, int ticketTypeId, Guid ticketId);
    Task<object> GetTicketUserAsync(string serviceName, int ticketTypeId, Guid ticketId, Guid userId);
    Task<TicketDataModel> ListTicketsAgentAsync(FiltersAgentRequestModel filtersAgentDto);
    Task<TicketDataModel> ListTicketsUserAsync(FiltersUserDto filtersUserDto);
}
