using Flunt.Notifications;
using MediatR;
using MGP.MisTramites.CrossCutting.ResponseData;
namespace MGP.MisTramites.Application.UseCase.V1.User.GetTicket;

public class GetTicketUserRequest : Notifiable, IRequest<ResponseData<object, ResponseMessage>>
{
    public Guid UserId { get; set; }
    public string ServiceName { get; set; }
    public Guid TicketId { get; set; }
    public int TicketTypeId { get; set; }
}
