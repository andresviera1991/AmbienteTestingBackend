using Flunt.Notifications;
using MediatR;
using MGP.Discapacidad.CrossCutting.ResponseData;
using MGP.Discapacidad.Persistance.DTOs.Document;
using System;
using System.Collections.Generic;

namespace MGP.Discapacidad.Application.UseCase.V1.Agent.Ticket.PARKING.Update;

public class UpdateTicketParkingRequest : Notifiable, IRequest<ResponseData<UpdateTicketParkingResponse, ResponseMessage>>
{
    public Guid TicketId { get; set; }
    public string UserEmail { get; set; }
    public Guid AssignedAgentId { get; set; }
    public int TicketStatusId { get; set; }
    public string GDECode { get; set; }
    public List<UpdateDocumentStatusData> UpdateDocumentStatus { get; set; }
}
