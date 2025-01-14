using MGP.MisTramites.Client.DTOs.Request;
using MGP.MisTramites.Client.DTOs.Response.ListTicket;
using Newtonsoft.Json.Linq;
namespace MGP.MisTramites.Client.Interface.Discapacidad;

public interface IDiscapacidadClient
{
    public Task<object> GetTicketAgentAsync(Guid ticketId, string endpoint);
    public Task<object> GetTicketUserAsync(Guid ticketId, Guid userId, string endpoint);
    public Task<TicketDataModel> ListTicketAgentAsync (FiltersAgentRequestModel filtersAgentDto, string baseUrl);
}
