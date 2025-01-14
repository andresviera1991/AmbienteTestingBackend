using System;
namespace MGP.Discapacidad.Persistance.DTOs.Document;

public class UpdateDocumentStatusData
{
    public Guid DocumentId { get; set; }
    public int DocumentStatusId { get; set; }
}
