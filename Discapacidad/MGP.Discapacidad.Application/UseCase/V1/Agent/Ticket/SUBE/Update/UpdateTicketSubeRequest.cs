using Flunt.Notifications;
using MediatR;
using MGP.Discapacidad.CrossCutting.ResponseData;
using MGP.Discapacidad.Persistance.DTOs.Document;
using System;
using System.Collections.Generic;

namespace MGP.Discapacidad.Application.UseCase.V1.Agent.Ticket.SUBE.Update;

public class UpdateTicketSubeRequest : Notifiable, IRequest<ResponseData<UpdateTicketSubeResponse,ResponseMessage>>
{
    public Guid TicketId { get; set; }
    public Guid AssignedAgentId { get; set; }
    public int TicketStatusId { get; set; }
    public string UserEmail { get; set; }
    public int CardPickupLocationsOptionsId { get; set; }
    public string CudCertificateNumber { get; set; }
    public DateTime? CudExpirationDate { get; set; }
    public string GDECode { get; set; }
    public List<UpdateDocumentStatusData> UpdateDocumentStatus { get; set; }

}
