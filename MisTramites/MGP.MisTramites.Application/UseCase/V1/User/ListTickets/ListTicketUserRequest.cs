using MediatR;
using Flunt.Notifications;
using MGP.MisTramites.CrossCutting.ResponseData;
using MGP.MisTramites.Client.DTOs.Response.ListTicket;
namespace MGP.MisTramites.Application.UseCase.V1.User.ListTickets;

public class ListTicketUserRequest : Notifiable, IRequest<ResponseData<TicketDataModel, ResponseMessage>>
{
    public Guid UserId { get; set; }
    public string TicketCode { get; set; }
    public int? TicketTypeId { get; set; }
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
}
