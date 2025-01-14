using Swashbuckle.AspNetCore.Annotations;
namespace MGP.Backoffice.Api.Controllers.Agent.Request.Update;
public class TicketTypeRequestModel
{
    /// <example>1</example>
    [SwaggerSchema("Ticket Type Id")]
    public int Id { get; set; }

}
