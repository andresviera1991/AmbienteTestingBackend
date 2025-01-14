using Swashbuckle.AspNetCore.Annotations;
using System;
namespace MGP.Discapacidad.API.Controllers.V1.Ticket.SupervisorTicket.Request;

[SwaggerSchema("Data structure containing request details for create a ticket CUD", Required = ["SupervisorId", "TicketId", "AgentId"])]
public class ReassignTicketRequestModel
{

    /// <example>13f76a47-024e-4930-af9c-9f80e7c478ff</example>
    [SwaggerSchema("Agent Id")]
    public Guid AgentId { get; set; }

    /// <example>c52573f5-6624-44fe-9504-a380c946ccd7</example>
    [SwaggerSchema("Ticket Id")]
    public Guid TicketId { get; set; }
}
