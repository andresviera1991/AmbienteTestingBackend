using MediatR;
using MGP.Discapacidad.CrossCutting.ResponseData;
using System;

namespace MGP.Discapacidad.Application.UseCase.V1.Document.RemoveDocument;

public class RemoveDocumentRequest : IRequest<ResponseData<RemoveDocumentResponse, ResponseMessage>>
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }
}
