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
namespace MGP.Discapacidad.Application.UseCase.V1.Document.AddTemplate;
public class AddTemplateHandler : IRequestHandler<AddTemplateRequest, ResponseData<AddTemplateResponse, ResponseMessage>>
{
    private readonly IDocumentService _documentService;
    private readonly IMapper _mapper;
    private readonly MessageManager _messageManager;
    private readonly IValidator<AddTemplateRequest> _validator;

    public AddTemplateHandler(IDocumentService DocumentTypeService,
                              IMapper mapper,
                              MessageManager messageManager,
                              IValidator<AddTemplateRequest> validator)
    {
        _documentService = DocumentTypeService;
        _mapper = mapper;
        _messageManager = messageManager;
        _validator = validator;
    }

    public async Task<ResponseData<AddTemplateResponse, ResponseMessage>> Handle(AddTemplateRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
            {
                var errorMessages = validationResult.Errors.Select(error => error.ErrorMessage).ToList();
                throw new ParameterNotProviderException(errorMessages);
            }

            AddTemplateResponse addTemplateResponse = new AddTemplateResponse()
            {
                Id = await _documentService.AddTemplateAsync(_mapper.Map<AddTemplateData>(request))
            };

            var responseData = new ResponseData<AddTemplateResponse, ResponseMessage>(
                code: (int)Code.CREATED,
                data: addTemplateResponse,
                message: null);

            return await Task.FromResult(responseData);

        }
        catch (TemplateDocumentAlreadyExistsException)
        {
            return await HandleException(Code.CONFLICT, [_messageManager.GetNotification(FunctionalMessages.TEMPLATE_ALREADY_EXISTS)], null);
        }
        catch (ParameterNotProviderException e)
        {
            return await HandleException(Code.BAD_REQUEST, e.Errors);
        }
        catch (TicketTypeNotFoundException)
        {
            return await HandleException(Code.NOT_FOUND, [_messageManager.GetNotification(FunctionalMessages.TICKET_TYPE_NOT_FOUND)], null);
        }
        catch (Exception)
        {
            return await HandleException(Code.SERVICE_UNAVAILABLE, [_messageManager.GetNotification(FunctionalMessages.SERVICE_UNAVAILABLE)], null);
        }
    }

    private async Task<ResponseData<AddTemplateResponse, ResponseMessage>> HandleException(Code errorCode, List<string> message, AddTemplateResponse response = null)
    {
        var responseData = new ResponseData<AddTemplateResponse, ResponseMessage>(
                           code: (int)errorCode,
                           data: response,
                           message: new ResponseMessage()
                           {
                               Message = message
                           });

        return await Task.FromResult(responseData);
    }

}
