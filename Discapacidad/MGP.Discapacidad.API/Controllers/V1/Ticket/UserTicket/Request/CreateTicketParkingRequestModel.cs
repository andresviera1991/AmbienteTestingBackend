using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace MGP.Discapacidad.API.Controllers.V1.Ticket.UserTicket.Request;

public class CreateTicketParkingRequestModel
{
    [SwaggerSchema("Receives the TypeDocument and the BASE64 image or file")]
    public List<DocumentRequestModel> Documents { get; set; }
}
