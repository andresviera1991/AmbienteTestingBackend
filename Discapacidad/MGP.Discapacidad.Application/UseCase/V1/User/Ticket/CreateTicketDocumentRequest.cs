using System;

namespace MGP.Discapacidad.Application.UseCase.V1.User.Ticket;

public class CreateTicketDocumentRequest
{
    public Guid UserId { get; set; }
    public Guid TicketId { get; set; }
    public int DocumentTypeId { get; set; }
    public string DocumentImage { get; set; }
}
