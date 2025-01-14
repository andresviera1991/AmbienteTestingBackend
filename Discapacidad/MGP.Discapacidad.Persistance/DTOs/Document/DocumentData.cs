using System;
using MGP.Discapacidad.Persistance.Data.Tables;
namespace MGP.Discapacidad.Persistance.DTOs.Document;

public class DocumentData
{

    public Guid Id { get; set; }

    public string DocumentImage { get; set; }

    public Guid TicketId { get; set; }

    public int DocumentStatusId { get; set; }

    public virtual DocumentStatus DocumentStatus { get; set; }

    public int DocumentTypeId { get; set; }

    public virtual DocumentType DocumentType { get; set; }

}
