using System;
namespace MGP.Discapacidad.Persistance.DTOs.Document;
public class UpdateTemplateData 
{
    public Guid Id { get; set; }
    public int TicketTypeId { get; set; }
    public string Name { get; set; }
    public string Information { get; set; }
    public bool? Status { get; set; }
}
