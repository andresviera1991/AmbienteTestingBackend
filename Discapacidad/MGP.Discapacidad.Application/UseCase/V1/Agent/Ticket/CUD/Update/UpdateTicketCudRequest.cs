using Flunt.Notifications;
using MediatR;
using MGP.Discapacidad.CrossCutting.ResponseData;
using MGP.Discapacidad.Persistance.DTOs.Document;
using System;
using System.Collections.Generic;
namespace MGP.Discapacidad.Application.UseCase.V1.Agent.Ticket.CUD.Update;

public class UpdateTicketCudRequest : Notifiable, IRequest<ResponseData<UpdateTicketCudResponse,ResponseMessage>>
{
    public Guid TicketId { get; set; }
    public string UserEmail { get; set; }
    public int TicketStatusId { get; set; }
    public int CertificateExpansionOptionsId { get; set; }
    public int SignatureOptionsId { get; set; }
    public bool Certificate { get; set; }
    public bool ExpiredCertificate { get; set; }
    public bool LostCertificate { get; set; }
    public bool HealthInsurance { get; set; }
    public bool PaySlip { get; set; }
    public bool DocumentComplete { get; set; }
    public DateTime? MedicalCommitteDate { get; set; }
    public string GDECode { get; set; }
    public List<UpdateDocumentStatusData> UpdateDocumentStatus { get; set; }
}
