using Flunt.Notifications;
using MediatR;
using MGP.Discapacidad.Application.UseCase.V1.Agent.Ticket.LIST.ListTicket;
using MGP.Discapacidad.CrossCutting.ResponseData;
using System;
using System.Collections.Generic;

namespace MGP.Discapacidad.Application.UseCase.V1.Agent.Ticket.List.ListTicketByAgent;

public class ListTicketAgentRequest : Notifiable, IRequest<ResponseData<ListTicketAgentResponse, ResponseMessage>>
{
    public List<Guid> UserIds { get; set; }
    public Guid? AgentId { get; set; }
    public int? TicketStatusId { get; set; }
    public string TicketCode { get; set; }
    public int? TicketTypeId { get; set; }
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
}
