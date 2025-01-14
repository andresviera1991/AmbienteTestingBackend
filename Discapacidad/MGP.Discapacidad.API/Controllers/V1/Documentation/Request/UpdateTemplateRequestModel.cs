using Swashbuckle.AspNetCore.Annotations;
using System;
namespace MGP.Discapacidad.API.Controllers.V1.Document.Request;

[SwaggerSchema("Contains the necessary information to add a template",
    Required = ["Id", "DocumentTypeId", "DocumentUrl"])]
public class UpdateTemplateRequestModel
{

    /// <example>00526b63-5215-490f-9347-d24c00ccd235</example>
    [SwaggerSchema("Template Id")]
    public Guid Id { get; set; }

    /// <example>1</example>
    [SwaggerSchema("TicketTypeData")]
    public int TicketTypeId { get; set; }

    /// <example>Patologías Cardiovasulares Crónicas</example>
    [SwaggerSchema("Nombre de Planilla")]
    public string Name { get; set; }

    /// <example>Esta planilla es importante...</example>
    [SwaggerSchema("Information")]
    public string Information { get; set; }

    /// <example>True</example>
    [SwaggerSchema("Status")]
    public bool? Status { get; set; }
}
