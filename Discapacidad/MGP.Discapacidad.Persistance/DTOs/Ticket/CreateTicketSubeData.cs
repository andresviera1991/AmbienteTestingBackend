using MGP.Discapacidad.Persistance.DTOs.Document;
using System;
using System.Collections.Generic;
namespace MGP.Discapacidad.Persistance.DTOs.Ticket;
public class CreateTicketSubeData
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string Email { get; set; }
    public string TicketCode { get; set; }
    public int TicketStatusId { get; set; }
    public int TicketTypeId { get; set; }
    public int CardPickupId { get; set; }
    public string CudCertificateNumber { get; set; }
    public DateTime CudExpirationDate { get; set; }
    public Guid? AgentId { get; set; }
    public Guid? AssignedAgentId { get; set; }
    public virtual List<DocumentData> Documents { get; set; }
}
