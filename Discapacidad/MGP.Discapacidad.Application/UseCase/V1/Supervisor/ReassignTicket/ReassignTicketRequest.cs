using Flunt.Notifications;
using MediatR;
using MGP.Discapacidad.CrossCutting.ResponseData;
using System;
namespace MGP.Discapacidad.Application.UseCase.V1.Supervisor.ReassignTicket;

public class ReassignTicketRequest : Notifiable, IRequest<ResponseData<ReassignTicketResponse, ResponseMessage>>
{
    public Guid SupervisorId { get; set; }
    public Guid AgentId { get; set; }
    public Guid TicketId { get; set; }
}
