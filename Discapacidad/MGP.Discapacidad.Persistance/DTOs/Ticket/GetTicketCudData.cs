using MGP.Discapacidad.Persistance.DTOs.Catalog;
using System;
namespace MGP.Discapacidad.Persistance.DTOs.Ticket;

public class GetTicketCudData
{

    public Guid Id { get; set; }

    public TicketData Ticket { get; set; }

    public CertificateExpansionOptionsData CertificateExpansionOptions { get; set; }

    public bool Certificate { get; set; }

    public bool ExpiredCertificate { get; set; }

    public bool LostCertificate { get; set; }

    public bool HealthInsurance { get; set; }

    public bool PaySlip { get; set; }

    public virtual SignatureOptionsData SignatureOption { get; set; }

    public bool DocumentComplete { get; set; }

    public DateTime? MedicalCommitteData { get; set; }
}
