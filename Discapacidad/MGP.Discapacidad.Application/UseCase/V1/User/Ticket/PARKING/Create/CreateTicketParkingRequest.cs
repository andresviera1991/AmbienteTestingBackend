using Flunt.Notifications;
using MediatR;
using MGP.Discapacidad.CrossCutting.ResponseData;
using System.Collections.Generic;
using System;

namespace MGP.Discapacidad.Application.UseCase.V1.User.Ticket.PARKING.Create;

public class CreateTicketParkingRequest : Notifiable, IRequest<ResponseData<CreateTicketParkingResponse, ResponseMessage>>
{
    public Guid? UserId { get; set; }
    public string Email { get; set; }
    public List<CreateTicketDocumentRequest> Documents { get; set; }
}
