using AutoMapper;
using FluentValidation;
using MediatR;
using MGP.Discapacidad.Application.UseCase.V1.Document.AddTemplate;
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

namespace MGP.Discapacidad.Application.UseCase.V1.Document.RemoveTemplate;

public class RemoveTemplateHandler : IRequestHandler<RemoveTemplateRequest, ResponseData<RemoveTemplateResponse, ResponseMessage>>
{
    private readonly IDocumentService _documentService;
    private readonly MessageManager _messageManager;
    private readonly IValidator<RemoveTemplateRequest> _validator;

    public RemoveTemplateHandler(IDocumentService DocumentTypeService,
                                 MessageManager messageManager,
                                 IValidator<RemoveTemplateRequest> validator)
    {
        _documentService = DocumentTypeService;
        _messageManager = messageManager;
        _validator = validator;
    }

    public async Task<ResponseData<RemoveTemplateResponse, ResponseMessage>> Handle(RemoveTemplateRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
            {
                var errorMessages = validationResult.Errors.Select(error => error.ErrorMessage).ToList();
                throw new ParameterNotProviderException(errorMessages);
            }

            await _documentService.RemoveTemplateAsync(request.Id);

            var responseData = new ResponseData<RemoveTemplateResponse, ResponseMessage>(
                code: (int)Code.SUCCESS,
                data: new RemoveTemplateResponse() { Success = true },
                message: null);

            return await Task.FromResult(responseData);

        }
        catch (ParameterNotProviderException e)
        {
            return await HandleException(Code.BAD_REQUEST, e.Errors);
        }
        catch (TemplateNotFoundException)
        {
            return await HandleException(Code.NOT_FOUND, [_messageManager.GetNotification(FunctionalMessages.TEMPLATE_NOT_FOUND)], null);
        }
        catch (Exception)
        {
            return await HandleException(Code.SERVICE_UNAVAILABLE, [_messageManager.GetNotification(FunctionalMessages.SERVICE_UNAVAILABLE)], null);
        }
    }

    private async Task<ResponseData<RemoveTemplateResponse, ResponseMessage>> HandleException(Code errorCode, List<string> message, RemoveTemplateResponse response = null)
    {
        var responseData = new ResponseData<RemoveTemplateResponse, ResponseMessage>(
                           code: (int)errorCode,
                           data: response,
                           message: new ResponseMessage()
                           {
                               Message = message
                           });

        return await Task.FromResult(responseData);
    }

}
