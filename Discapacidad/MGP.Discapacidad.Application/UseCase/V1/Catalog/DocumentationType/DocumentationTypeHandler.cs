using MediatR;
using MGP.Discapacidad.CrossCutting.Helpers;
using MGP.Discapacidad.CrossCutting.Messages;
using MGP.Discapacidad.CrossCutting.MessagesManager;
using MGP.Discapacidad.CrossCutting.ResponseData;
using MGP.Discapacidad.Domain.interfaces;
using MGP.Discapacidad.Persistance.DTOs.Catalog;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
namespace MGP.Discapacidad.Application.UseCase.V1.Catalog.DocumentType;

public class DocumentTypeHandler : IRequestHandler<DocumentTypeRequest, ResponseData<List<DocumentTypeData>, ResponseMessage>>
{
    private readonly ICatalogService _catalogService;
    private readonly MessageManager _messageManager;

    public DocumentTypeHandler(ICatalogService catalogService,
                               MessageManager messageManager)
    {
        _catalogService = catalogService;
        _messageManager = messageManager;
    }

    public async Task<ResponseData<List<DocumentTypeData>, ResponseMessage>> Handle(DocumentTypeRequest request, CancellationToken cancellationToken)
    {
        try
        {
            List<DocumentTypeData> DocumentTypeData = await _catalogService.ListDocumentTypeAsync();

            var responseData = new ResponseData<List<DocumentTypeData>, ResponseMessage>(
                code: (int)Code.SUCCESS,
                data: DocumentTypeData,
                message: null);

            return await Task.FromResult(responseData);

        }
        catch (InvalidOperationException)
        {

            var responseData = new ResponseData<List<DocumentTypeData>, ResponseMessage>(
                code: (int)Code.SERVICE_UNAVAILABLE,
                data: null,
                message: new ResponseMessage()
                {
                    Message = new List<string>
                    {
                        _messageManager.GetNotification(FunctionalMessages.SERVICE_UNAVAILABLE)
                    }
                }
            );
            return await Task.FromResult(responseData);
        }
    }
}
