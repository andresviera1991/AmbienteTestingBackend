using Swashbuckle.AspNetCore.Annotations;
using System;

namespace MGP.Discapacidad.API.Controllers.V1.Ticket.UserTicket.Request;

[SwaggerSchema("Contains the Code of a ticket to retrieve a ticket",
    Required = ["Code"])]
public class GetTicketRequestModel
{
    /// <example>5</example>
    [SwaggerSchema("Ticked Code")]
    public string TicketCode { get; set; }

    /// <example>63dd6a2a-a7e9-4601-9f33-d9e7a0cc30d4</example>
    [SwaggerSchema("Ticked Id")]
    public Guid TicketId { get; set; }
}
