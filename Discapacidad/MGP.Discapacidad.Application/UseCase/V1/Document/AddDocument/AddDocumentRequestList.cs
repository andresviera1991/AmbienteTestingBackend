using Flunt.Notifications;
using MediatR;
using MGP.Discapacidad.CrossCutting.ResponseData;
using System;
using System.Collections.Generic;
namespace MGP.Discapacidad.Application.UseCase.V1.Document.AddDocument;

public class AddDocumentRequestList : Notifiable, IRequest<ResponseData<List<AddDocumentResponse>, ResponseMessage>>
{
    public Guid? UserId { get; set; }
    public Guid TicketId { get; set; }
    public IEnumerable<AddDocumentRequest> Documents { get; set; }
}
