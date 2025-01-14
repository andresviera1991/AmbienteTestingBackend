using Flunt.Notifications;
using MediatR;
using MGP.Discapacidad.CrossCutting.ResponseData;
using System;
namespace MGP.Discapacidad.Application.UseCase.V1.User.Ticket.Update;

public class CancelTicketRequest : Notifiable, IRequest<ResponseData<CancelTicketResponse, ResponseMessage>>
{
    public Guid UserId { get; set; }
    public Guid TicketId { get; set; }
}
