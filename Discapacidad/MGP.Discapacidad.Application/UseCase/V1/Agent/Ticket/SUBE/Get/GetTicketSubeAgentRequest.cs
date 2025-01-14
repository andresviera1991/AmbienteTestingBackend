using Flunt.Notifications;
using MediatR;
using MGP.Discapacidad.CrossCutting.ResponseData;
using MGP.Discapacidad.Persistance.DTOs.Ticket;
using System;
namespace MGP.Discapacidad.Application.UseCase.V1.Agent.Ticket.SUBE.Get;
public class GetTicketSubeAgentRequest : Notifiable, IRequest<ResponseData<GetTicketSubeData, ResponseMessage>>
{
    public Guid TicketId { get; set; }
    public string TicketCode { get; set; }
}
