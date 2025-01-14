using Swashbuckle.AspNetCore.Annotations;
using System;
namespace MGP.Discapacidad.API.Controllers.V1.Ticket.Request;

[SwaggerSchema("")]
public class GetTicketRequestModel
{
    /// <example>DISCAPACIDAD</example>
    [SwaggerSchema("Microservice Name")]
    public string ServiceName { get; set; }

    /// <example>96aaeb4b-19bc-48d2-9f30-bac40ff4139b</example>
    [SwaggerSchema("Ticked Id")]
    public Guid TicketId { get; set; }

    /// <example>1</example>
    [SwaggerSchema("TicketType Id")]
    public int TicketTypeId { get; set; }
}
