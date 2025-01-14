using AutoMapper;
using FluentValidation;
using MediatR;
using MGP.Discapacidad.CrossCutting.Excepciones;
using MGP.Discapacidad.CrossCutting.Helpers;
using MGP.Discapacidad.CrossCutting.Messages;
using MGP.Discapacidad.CrossCutting.MessagesManager;
using MGP.Discapacidad.CrossCutting.ResponseData;
using MGP.Discapacidad.Domain.interfaces;
using MGP.Discapacidad.Persistance.DTOs.Document;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace MGP.Discapacidad.Application.UseCase.V1.Document.UpdateTemplate;

public class UpdateTemplateHandler : IRequestHandler<UpdateTemplateRequest, ResponseData<UpdateTemplateResponse, ResponseMessage>>
{
    private readonly IDocumentService _documentService;
    private readonly IMapper _mapper;
    private readonly MessageManager _messageManager;
    private readonly IValidator<UpdateTemplateRequest> _validator;

    public UpdateTemplateHandler(IDocumentService documentService,
                                 IMapper mapper,
                                 MessageManager messageManager,
                                 IValidator<UpdateTemplateRequest> validator)
    {
        _documentService = documentService;
        _mapper = mapper;
        _messageManager = messageManager;
        _validator = validator;
    }

    public async Task<ResponseData<UpdateTemplateResponse, ResponseMessage>> Handle(UpdateTemplateRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
            {
                var errorMessages = validationResult.Errors.Select(error => error.ErrorMessage).ToList();
                throw new ParameterNotProviderException(errorMessages);
            }

            await _documentService.UpdateTemplateAsync(_mapper.Map<UpdateTemplateData>(request));

            var responseData = new ResponseData<UpdateTemplateResponse, ResponseMessage>(
                code: (int)Code.SUCCESS,
                data: new UpdateTemplateResponse() { Success = true },
                message: null);

            return await Task.FromResult(responseData);

        }
        catch (TemplateNotFoundException)
        {
            return await HandleException(Code.NOT_FOUND, [_messageManager.GetNotification(FunctionalMessages.TEMPLATE_NOT_FOUND)], null);
        }
        catch (TicketTypeNotFoundException)
        {
            return await HandleException(Code.NOT_FOUND, [_messageManager.GetNotification(FunctionalMessages.TICKET_TYPE_NOT_FOUND)], null);
        }
        catch (ParameterNotProviderException e)
        {
            return await HandleException(Code.BAD_REQUEST, e.Errors);
        }
        catch (Exception)
        {
            return await HandleException(Code.SERVICE_UNAVAILABLE, [_messageManager.GetNotification(FunctionalMessages.SERVICE_UNAVAILABLE)], null);
        }
    }

    private async Task<ResponseData<UpdateTemplateResponse, ResponseMessage>> HandleException(Code errorCode, List<string> message, UpdateTemplateResponse response = null)
    {
        var responseData = new ResponseData<UpdateTemplateResponse, ResponseMessage>(
                           code: (int)errorCode,
                           data: response,
                           message: new ResponseMessage()
                           {
                               Message = message
                           });

        return await Task.FromResult(responseData);
    }

}
