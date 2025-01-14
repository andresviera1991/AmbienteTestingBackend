using MGP.Discapacidad.API.Controllers.V1.Ticket.UserTicket.Request;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;

namespace MGP.Discapacidad.API.Controllers.V1.Ticket.AgentTicket.Request;

public class CreateTicketSubeAgentRequestModel
{

    /// <example>d1490967-8032-4ff3-8c1e-f8a8d39b50cf</example>
    [SwaggerSchema("User Id")]
    public Guid UserId { get; set; }

    /// <example>1</example>
    [SwaggerSchema("Card Locations Options")]
    public int CardPickupId { get; set; }

    /// <example>123</example>
    [SwaggerSchema("Cud Certificate Number")]
    public string CudCertificateNumber { get; set; }

    /// <example>2024-12-12</example>
    [SwaggerSchema("Cud Expiration Date")]
    public DateTime? CudExpirationDate { get; set; }

    [SwaggerSchema("Receives the TypeDocument and the BASE64 image or file")]
    public List<DocumentRequestModel> Documents { get; set; }
}
