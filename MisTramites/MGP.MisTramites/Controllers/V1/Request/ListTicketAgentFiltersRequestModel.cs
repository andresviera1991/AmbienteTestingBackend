using Swashbuckle.AspNetCore.Annotations;
using System;
namespace MGP.Discapacidad.API.Controllers.V1.Ticket.Request;

[SwaggerSchema("")]
public class ListTicketAgentFiltersRequestModel
{
    /// <example>DISCAPACIDAD</example>
    [SwaggerSchema("Microservice Name")]
    public string ServiceName { get; set; }

    /// <example>Marcos Lopez</example>
    [SwaggerSchema("User Full Name")]
    public string FullName { get; set; }

    /// <example>44413552</example>
    [SwaggerSchema("Document Number")]
    public string DocumentNumber { get; set; }

    /// <example>DS-DIS-01</example>
    [SwaggerSchema("Ticked Code")]
    public string TicketCode { get; set; }

    /// <example>1</example>
    [SwaggerSchema("Ticket Type Id")]
    public int? TicketTypeId { get; set; }

    /// <example>1</example>
    [SwaggerSchema("Ticket Status Id")]
    public int? TicketStatusId { get; set; }

    /// <example>18d14490-91c1-4ba6-843c-9b501d187050</example>
    [SwaggerSchema("Agent Id")]
    public Guid? AgentId { get; set; }

    /// <example>false</example>
    [SwaggerSchema("AssignedToMe")]
    public bool AssignedToMe { get; set; }

    /// <example>1</example>
    [SwaggerSchema("Page Number")]
    public int PageNumber { get; set; }

    /// <example>10</example>
    [SwaggerSchema("Page Size")]
    public int PageSize { get; set; }
}
