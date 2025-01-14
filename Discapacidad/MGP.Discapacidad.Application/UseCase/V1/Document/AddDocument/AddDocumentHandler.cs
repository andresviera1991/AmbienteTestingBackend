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
namespace MGP.Discapacidad.Application.UseCase.V1.Document.AddDocument;

public class AddDocumentHandler : IRequestHandler<AddDocumentRequestList, ResponseData<List<AddDocumentResponse>, ResponseMessage>>
{
    private readonly IDocumentService _DocumentService;
    private readonly IMapper _mapper;
    private readonly MessageManager _messageManager;
    private readonly IValidator<AddDocumentRequestList> _validator;

    public AddDocumentHandler(IDocumentService DocumentTypeService,
                              IMapper mapper,
                              MessageManager messageManager,
                              IValidator<AddDocumentRequestList> validator)
    {
        _DocumentService = DocumentTypeService;
        _mapper = mapper;
        _messageManager = messageManager;
        _validator = validator;
    }

    public async Task<ResponseData<List<AddDocumentResponse>, ResponseMessage>> Handle(AddDocumentRequestList request, CancellationToken cancellationToken)
    {
        try
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
            {
                var errorMessages = validationResult.Errors.Select(error => error.ErrorMessage).ToList();
                throw new ParameterNotProviderException(errorMessages);
            }
            List<DocumentData> requestDoucmentData = _mapper.Map<List<DocumentData>>(request.Documents);

            List<AddDocumentResponse> response = _mapper.Map<List<AddDocumentResponse>>(await _DocumentService.AddDocumentAsync(requestDoucmentData, request.UserId, request.TicketId));

            var responseData = new ResponseData<List<AddDocumentResponse>, ResponseMessage>(
                code: (int)Code.CREATED,
                data: response,
                message: null);

            return await Task.FromResult(responseData);

        }
        catch (TicketNotFoundException)
        {
            return await HandleException(Code.NOT_FOUND, [_messageManager.GetNotification(FunctionalMessages.TICKET_NOT_FOUND)], null);
        }
        catch (DocumentTypeNotFoundException)
        {
            return await HandleException(Code.NOT_FOUND, [_messageManager.GetNotification(FunctionalMessages.DOCUMENT_TYPE_NOT_FOUND)], null);
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

    private async Task<ResponseData<List<AddDocumentResponse>, ResponseMessage>> HandleException(Code errorCode, List<string> message, List<AddDocumentResponse> response = null)
    {
        var responseData = new ResponseData<List<AddDocumentResponse>, ResponseMessage>(
                           code: (int)errorCode,
                           data: response,
                           message: new ResponseMessage()
                           {
                               Message = message
                           });

        return await Task.FromResult(responseData);
    }
}
