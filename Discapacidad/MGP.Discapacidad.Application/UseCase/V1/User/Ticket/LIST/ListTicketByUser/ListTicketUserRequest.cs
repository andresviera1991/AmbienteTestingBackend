using Flunt.Notifications;
using MediatR;
using MGP.Discapacidad.CrossCutting.ResponseData;
using MGP.Discapacidad.Persistance.DTOs.Ticket;
using System;

namespace MGP.Discapacidad.Application.UseCase.V1.User.Ticket.List.ListTicketByUser;
public class ListTicketUserRequest : Notifiable, IRequest<ResponseData<ListTicketData[], ResponseMessage>>
{
    public Guid UserId { get; set; }
}
