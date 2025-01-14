using Swashbuckle.AspNetCore.Annotations;
using System;
namespace MGP.Discapacidad.API.Controllers.V1.Ticket.AgentTicket.Request;

public class UpdateDocumentStatusRequestModel
{
    /// <example>aa40e0c3-db02-4b02-80f9-754e2317dc90</example>
    [SwaggerSchema("Document Id")]
    public Guid DocumentId { get; set; }

    /// <example>2</example>
    [SwaggerSchema("Document Status Id")]
    public int DocumentStatusId { get; set; }
}
