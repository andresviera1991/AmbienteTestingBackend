using MGP.Discapacidad.Persistance.DTOs.Document;
using System;
using System.Collections.Generic;
namespace MGP.Discapacidad.Persistance.DTOs.Ticket;

public class UpdateTicketParkingData
{
    public Guid TicketId { get; set; }
    public string UserEmail { get; set; }
    public int TicketStatusId { get; set; }
    public string GDECode { get; set; }
    public List<UpdateDocumentStatusData> UpdateDocumentStatus { get; set; }
}
