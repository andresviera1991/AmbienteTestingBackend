using FluentValidation;
using MediatR;
using MGP.Discapacidad.CrossCutting.Excepciones;
using MGP.Discapacidad.CrossCutting.Helpers;
using MGP.Discapacidad.CrossCutting.Messages;
using MGP.Discapacidad.CrossCutting.MessagesManager;
using MGP.Discapacidad.CrossCutting.ResponseData;
using MGP.Discapacidad.Domain.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace MGP.Discapacidad.Application.UseCase.V1.Document.RemoveDocument;

public class RemoveDocumentHandler : IRequestHandler<RemoveDocumentRequest, ResponseData<RemoveDocumentResponse, ResponseMessage>>
{
    private readonly IDocumentService _DocumentService;
    private readonly MessageManager _messageManager;
    private readonly IValidator<RemoveDocumentRequest> _validator;

    public RemoveDocumentHandler(IDocumentService DocumentTypeService,
                                 MessageManager messageManager,
                                 IValidator<RemoveDocumentRequest> validator)
    {
        _DocumentService = DocumentTypeService;
        _messageManager = messageManager;
        _validator = validator;
    }

    public async Task<ResponseData<RemoveDocumentResponse, ResponseMessage>> Handle(RemoveDocumentRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
            {
                var errorMessages = validationResult.Errors.Select(error => error.ErrorMessage).ToList();
                throw new ParameterNotProviderException(errorMessages);
            }

            await _DocumentService.RemoveDocumentAsync(request.Id, request.UserId);

            var responseData = new ResponseData<RemoveDocumentResponse, ResponseMessage>(
                code: (int)Code.SUCCESS,
                data: new RemoveDocumentResponse() { Success = true },
                message: null);

            return await Task.FromResult(responseData);
        }
        catch (ParameterNotProviderException e)
        {
            return await HandleException(Code.BAD_REQUEST, e.Errors);
        }
        catch (TicketNotFoundException)
        {
            return await HandleException(Code.NOT_FOUND, [_messageManager.GetNotification(FunctionalMessages.TICKET_NOT_FOUND)]);
        }
        catch (DocumentNotFoundException)
        {
            return await HandleException(Code.NOT_FOUND, [_messageManager.GetNotification(FunctionalMessages.DOCUMENT_NOT_FOUND)]);
        }
        catch (Exception)
        {
            return await HandleException(Code.SERVICE_UNAVAILABLE, [_messageManager.GetNotification(FunctionalMessages.SERVICE_UNAVAILABLE)]);
        }
    }
    private async Task<ResponseData<RemoveDocumentResponse, ResponseMessage>> HandleException(Code errorCode, List<string> message, RemoveDocumentResponse removeDocumentResponse = null)
    {
        var responseData = new ResponseData<RemoveDocumentResponse, ResponseMessage>(
                           code: (int)errorCode,
                           data: removeDocumentResponse,
                           message: new ResponseMessage()
                           {
                               Message = message
                           });

        return await Task.FromResult(responseData);
    }
}
