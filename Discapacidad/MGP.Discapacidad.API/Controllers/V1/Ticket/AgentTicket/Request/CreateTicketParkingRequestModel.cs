using MGP.Discapacidad.API.Controllers.V1.Ticket.UserTicket.Request;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;

namespace MGP.Discapacidad.API.Controllers.V1.Ticket.AgentTicket.Request;

public class CreateTicketParkingAgentRequestModel
{
    /// <example>d1490967-8032-4ff3-8c1e-f8a8d39b50cf</example>
    [SwaggerSchema("User Id")]
    public Guid UserId { get; set; }

    [SwaggerSchema("Receives the TypeDocument and the BASE64 image or file")]
    public List<DocumentRequestModel> Documents { get; set; }
}
