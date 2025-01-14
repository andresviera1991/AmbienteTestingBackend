using System;
namespace MGP.Discapacidad.Persistance.DTOs.Document;

public class ListTemplateData
{
    public Guid Id { get; set; }
    public int TicketTypeId { get; set; }
    public string DocumentPath { get; set; }
    public string Name { get; set; }
    public string Information { get; set; }
    public DateTime CreationDate { get; set; }
}
