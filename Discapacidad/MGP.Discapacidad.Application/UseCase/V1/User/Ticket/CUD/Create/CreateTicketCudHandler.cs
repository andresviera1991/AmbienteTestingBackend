using MGP.Discapacidad.CrossCutting.MessagesManager;
using MGP.Discapacidad.Domain.interfaces;
using AutoMapper;
using FluentValidation;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using System;
using MGP.Discapacidad.Persistance.DTOs.Ticket;
using MGP.Discapacidad.CrossCutting.Helpers;
using MGP.Discapacidad.CrossCutting.ResponseData;
using MGP.Discapacidad.CrossCutting.Messages;
using MGP.Discapacidad.CrossCutting.Excepciones;
using System.Collections.Generic;
using System.Linq;

namespace MGP.Discapacidad.Application.UseCase.V1.User.Ticket.CUD.Create;

public class CreateTicketCudHandler : IRequestHandler<CreateTicketCudRequest, ResponseData<CreateTicketCudResponse, ResponseMessage>>
{
    private readonly ITicketService _TicketService;
    private readonly IValidator<CreateTicketCudRequest> _validator;
    private readonly IMapper _mapper;
    private readonly MessageManager _messageManager;

    public CreateTicketCudHandler(ITicketService TicketService,
                                  IValidator<CreateTicketCudRequest> validator,
                                  IMapper mapper,
                                  MessageManager messageManager)
    {
        _TicketService = TicketService;
        _validator = validator;
        _mapper = mapper;
        _messageManager = messageManager;
    }

    public async Task<ResponseData<CreateTicketCudResponse, ResponseMessage>> Handle(CreateTicketCudRequest request, CancellationToken cancellationToken)
    {
        CreateTicketCudResponse createTicketResponse = null;

        try
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
            {
                var errorMessages = validationResult.Errors.Select(error => error.ErrorMessage).ToList();
                throw new ParameterNotProviderException(errorMessages);
            }

            createTicketResponse = _mapper.Map<CreateTicketCudResponse>(await _TicketService.CreateTicketCudAsync(_mapper.Map<CreateTicketCudData>(request)));

            var responseData = new ResponseData<CreateTicketCudResponse, ResponseMessage>(
                        code: (int)Code.CREATED,
                        data: createTicketResponse,
                        message: new ResponseMessage()
                        {
                            Message = [_messageManager.GetNotification(FunctionalMessages.VERIFY_EMAIL)]
                        });

            return await Task.FromResult(responseData);
        }
        catch (ParameterNotProviderException p)
        {
            return await HandleException(Code.BAD_REQUEST, p.Errors);
        }
        catch (EmailException)
        {
            return await HandleException(Code.CREATED, [_messageManager.GetNotification(FunctionalMessages.ERROR_SEND_EMAIL)], createTicketResponse);
        }
        catch (DocumentTypeNotFoundException)
        {
            return await HandleException(Code.NOT_FOUND, [_messageManager.GetNotification(FunctionalMessages.DOCUMENT_TYPE_NOT_FOUND)]);
        }
        catch (TicketAlreadyOpenException)
        {
            return await HandleException(Code.CONFLICT, [_messageManager.GetNotification(FunctionalMessages.TICKET_ALREADY_OPEN)]);
        }
        catch (DocumentUploadException)
        {
            return await HandleException(Code.BAD_REQUEST, [_messageManager.GetNotification(FunctionalMessages.UPLOAD_DOCUMENT_ERROR)]);
        }
        catch (Exception)
        {
            return await HandleException(Code.SERVICE_UNAVAILABLE, [_messageManager.GetNotification(FunctionalMessages.SERVICE_UNAVAILABLE)]);
        }
    }
    private async Task<ResponseData<CreateTicketCudResponse, ResponseMessage>> HandleException(Code errorCode, List<string> messages, CreateTicketCudResponse response = null)
    {
        var responseData = new ResponseData<CreateTicketCudResponse, ResponseMessage>(
                           code: (int)errorCode,
                           data: response,
                           message: new ResponseMessage()
                           {
                               Message = messages
                           });

        return await Task.FromResult(responseData);
    }
}
