using MGP.Discapacidad.API.Controllers.V1.Document.Request;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
namespace MGP.Discapacidad.API.Controllers.V1.Documentation.Request;
public class AddDocumentRequestModelList
{
    /// <example>429928fb-0261-4f00-9b7e-b3da038727a6</example>
    [SwaggerSchema("Ticket Id")]
    public Guid TicketId { get; set; }

    [SwaggerSchema("DNI Front, Back, CUD, etc.")]
    public List<AddDocumentRequestModel> Documents { get; set; }

}
