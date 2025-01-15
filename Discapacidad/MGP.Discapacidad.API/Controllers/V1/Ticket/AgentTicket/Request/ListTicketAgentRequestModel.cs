using System;
using System.Collections.Generic;

namespace MGP.Discapacidad.API.Controllers.V1.Ticket.AgentTicket.Request;
public class ListTicketAgentRequestModel
{

    public List<Guid> UserIds { get; set; }
    public Guid? AgentId { get; set; }
    public string TicketCode { get; set; }
    public int? TicketStatusId { get; set; }
    public int? TicketTypeId { get; set; }
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
}
