using MGP.MisTramites.Client.DTOs.Request;
using MGP.MisTramites.Client.DTOs.Response.ListTicket;
using Microsoft.AspNetCore.Mvc;
using Refit;
namespace MGP.MisTramites.Client.Interface.Discapacidad;

[Headers("Content-Type: application/json")]
public interface IDiscapacidadApi
{
    [Get("")]
    Task<ApiResponse<object>> GetTicketAgentAsync([Query("ticketId")] Guid ticketId);

    [Get("")]
    Task<ApiResponse<object>> GetTicketUserAsync([Header("userId")] Guid userId, [Query("ticketId")] Guid ticketId);

    [Post("")]
    Task<ApiResponse<TicketResponseData>> ListTicketAgentAsync([FromBody] FiltersAgentRequestModel request);

}


