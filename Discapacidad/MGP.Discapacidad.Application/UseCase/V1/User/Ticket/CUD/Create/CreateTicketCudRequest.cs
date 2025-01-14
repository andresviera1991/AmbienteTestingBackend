using Flunt.Notifications;
using MediatR;
using MGP.Discapacidad.CrossCutting.ResponseData;
using System;
using System.Collections.Generic;
namespace MGP.Discapacidad.Application.UseCase.V1.User.Ticket.CUD.Create;
public class CreateTicketCudRequest : Notifiable, IRequest<ResponseData<CreateTicketCudResponse, ResponseMessage>>
{
    public Guid? UserId { get; set; }
    public string Email { get; set; }
    public string TicketCode { get; set; }
    public int? TicketStatusId { get; set; }
    public bool? Certificate { get; set; }
    public bool? ExpiredCertificate { get; set; }
    public int? CertificateExpansionOptionsId { get; set; }
    public bool? LostCertificate { get; set; }
    public bool? HealthInsurance { get; set; }
    public bool? PaySlip { get; set; }
    public int? SignatureOptionId { get; set; }
    public bool? DocumentComplete { get; set; }
    public Guid? MedicalCommitteId { get; set; }
    public virtual List<CreateTicketDocumentRequest> Documents { get; set; }
}
