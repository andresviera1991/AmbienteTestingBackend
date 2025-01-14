using Flunt.Notifications;
using MediatR;
using MGP.Discapacidad.CrossCutting.ResponseData;
using MGP.Discapacidad.Persistance.DTOs.Ticket;
using System;

namespace MGP.Discapacidad.Application.UseCase.V1.User.Ticket.SUBE.Get;

public class GetTicketSubeUserRequest : Notifiable, IRequest<ResponseData<GetTicketSubeData, ResponseMessage>>
{
    public Guid UserId { get; set; }
    public Guid TicketId { get; set; }
    public string TicketCode { get; set; }
}
