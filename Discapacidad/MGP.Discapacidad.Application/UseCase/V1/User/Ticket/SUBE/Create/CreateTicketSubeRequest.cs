using Flunt.Notifications;
using MediatR;
using MGP.Discapacidad.CrossCutting.ResponseData;
using System;
using System.Collections.Generic;

namespace MGP.Discapacidad.Application.UseCase.V1.User.Ticket.SUBE.Create;

public class CreateTicketSubeRequest : Notifiable, IRequest<ResponseData<CreateTicketSubeResponse, ResponseMessage>>
{
    public Guid? UserId { get; set; }
    public string Email { get; set; }
    public int CardPickupId { get; set; }
    public string CudCertificateNumber { get; set; }
    public DateTime? CudExpirationDate { get; set; }
    public List<CreateTicketDocumentRequest> Documents { get; set; }
}
