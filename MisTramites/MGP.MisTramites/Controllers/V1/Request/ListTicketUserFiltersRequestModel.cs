using Swashbuckle.AspNetCore.Annotations;
namespace MGP.Discapacidad.API.Controllers.V1.Ticket.Request;

[SwaggerSchema("")]
public class ListTicketUserFiltersRequestModel
{

    /// <example>DS-DIS-01</example>
    [SwaggerSchema("Ticked Code")]
    public string TicketCode { get; set; }

    /// <example>1</example>
    [SwaggerSchema("Ticket Type Id")]
    public int? TicketTypeId { get; set; }

    /// <example>1</example>
    [SwaggerSchema("Page Number")]
    public int PageNumber { get; set; }

    /// <example>10</example>
    [SwaggerSchema("Page Size")]
    public int PageSize { get; set; }
}
