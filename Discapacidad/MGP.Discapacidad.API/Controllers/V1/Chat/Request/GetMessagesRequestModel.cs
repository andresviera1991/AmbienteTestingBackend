using Swashbuckle.AspNetCore.Annotations;
using System;

namespace MGP.Discapacidad.API.Controllers.V1.Chat.Request;

[SwaggerSchema("", Required = ["TicketId"])]
public class GetMessagesRequestModel
{
    /// <example>e5bac0cf-c46d-46ad-a5b3-f23f3d44c54b</example>
    [SwaggerSchema("Ticket Id")]
    public Guid TicketId { get; set; }
}
