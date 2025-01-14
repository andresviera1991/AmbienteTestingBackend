using System;
using System.Collections.Generic;
using MGP.Discapacidad.Persistance.DTOs.Document;
namespace MGP.Discapacidad.Persistance.DTOs.Ticket;

public class CreateTicketCudData
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string Email { get; set; }
    public string TicketCode { get; set; }
    public int TicketStatusId { get; set; }
    public int TicketTypeId { get; set; }
    public bool Certificate { get; set; }
    public bool ExpiredCertificate { get; set; }
    public int CertificateExpansionOptionsId { get; set; }
    public bool LostCertificate { get; set; }
    public bool HealthInsurance { get; set; }
    public bool PaySlip { get; set; }
    public int SignatureOptionId { get; set; }
    public bool DocumentComplete { get; set; }
    public DateTime? MedicalCommitteDate { get; set; }
    public Guid? AgentId { get; set; }
    public Guid? AssignedAgentId { get; set; }
    public virtual List<DocumentData> Documents { get; set; }
}
