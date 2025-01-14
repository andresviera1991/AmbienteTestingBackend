using MediatR;
using MGP.Discapacidad.CrossCutting.Helpers;
using MGP.Discapacidad.CrossCutting.Messages;
using MGP.Discapacidad.CrossCutting.MessagesManager;
using MGP.Discapacidad.CrossCutting.ResponseData;
using MGP.Discapacidad.Domain.interfaces;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
namespace MGP.Discapacidad.Application.UseCase.V1.Document.ListTemplates;
public class ListTemplatesHandler : IRequestHandler<ListTemplatesRequest, ResponseData<ListTemplatesResponse, ResponseMessage>>
{
    private readonly IDocumentService _documentService;
    private readonly MessageManager _messageManager;
    public ListTemplatesHandler(IDocumentService documentService,
                              MessageManager messageManager)    
    {
        _documentService = documentService;
        _messageManager = messageManager;
    }

    public async Task<ResponseData<ListTemplatesResponse, ResponseMessage>> Handle(ListTemplatesRequest request, CancellationToken cancellationToken)
    {
        try
        {
            ListTemplatesResponse getTemplatesResponse = new ()
            {
                Templates = await _documentService.ListTemplatesAsync(request.TicketTypeId)
            };

            var responseData = new ResponseData<ListTemplatesResponse, ResponseMessage>(
                code: (int)Code.SUCCESS,
                data: getTemplatesResponse,
                message: null);

            return await Task.FromResult(responseData);
        }
        catch (Exception)
        {
            return await HandleException(Code.SERVICE_UNAVAILABLE, [_messageManager.GetNotification(FunctionalMessages.SERVICE_UNAVAILABLE)], null);
        }
    }

    private async Task<ResponseData<ListTemplatesResponse, ResponseMessage>> HandleException(Code errorCode, List<string> message, ListTemplatesResponse response = null)
    {
        var responseData = new ResponseData<ListTemplatesResponse, ResponseMessage>(
                           code: (int)errorCode,
                           data: response,
                           message: new ResponseMessage()
                           {
                               Message = message
                           });

        return await Task.FromResult(responseData);
    }
}
