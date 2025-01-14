using MediatR;
using MGP.Discapacidad.CrossCutting.ResponseData;
using System.Threading;
using System.Threading.Tasks;
using System;
using MGP.Discapacidad.Domain.interfaces;
using AutoMapper;
using FluentValidation;
using MGP.Discapacidad.CrossCutting.Excepciones;
using System.Linq;
using MGP.Discapacidad.Persistance.DTOs.Ticket;
using MGP.Discapacidad.CrossCutting.Helpers;
using MGP.Discapacidad.CrossCutting.Messages;
using MGP.Discapacidad.CrossCutting.MessagesManager;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MGP.Discapacidad.Application.UseCase.V1.User.Ticket.SUBE.Create;

public class CreateTicketSubeHandler : IRequestHandler<CreateTicketSubeRequest, ResponseData<CreateTicketSubeResponse, ResponseMessage>>
{
    private readonly ITicketService _ticketService;
    private readonly IMapper _mapper;
    private readonly IValidator<CreateTicketSubeRequest> _validator;
    private readonly MessageManager _messageManager;

    public CreateTicketSubeHandler(ITicketService ticketService,
                                    IMapper mapper,
                                    IValidator<CreateTicketSubeRequest> validator,
                                    MessageManager messageManager)
    {
        _mapper = mapper;
        _ticketService = ticketService;
        _validator = validator;
        _messageManager = messageManager;
    }
    public async Task<ResponseData<CreateTicketSubeResponse, ResponseMessage>> Handle(CreateTicketSubeRequest request, CancellationToken cancellationToken)
    {
        CreateTicketSubeResponse createTicketResponse = null;

        try
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
            {
                var errorMessages = validationResult.Errors.Select(error => error.ErrorMessage).ToList();
                throw new ParameterNotProviderException(errorMessages);
            }

            createTicketResponse = _mapper.Map<CreateTicketSubeResponse>(await _ticketService.CreateTicketSubeAsync(_mapper.Map<CreateTicketSubeData>(request)));

            var responseData = new ResponseData<CreateTicketSubeResponse, ResponseMessage>(
                        code: (int)Code.CREATED,
                        data: createTicketResponse,
                        message: null
                        );

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
        catch (TicketAlreadyOpenException)
        {
            return await HandleException(Code.CONFLICT, [_messageManager.GetNotification(FunctionalMessages.TICKET_ALREADY_OPEN)]);
        }
        catch (DocumentUploadException)
        {
            return await HandleException(Code.BAD_REQUEST, [_messageManager.GetNotification(FunctionalMessages.UPLOAD_DOCUMENT_ERROR)]);
        }
        catch (DocumentTypeNotFoundException)
        {
            return await HandleException(Code.NOT_FOUND, [_messageManager.GetNotification(FunctionalMessages.DOCUMENT_NOT_FOUND)]);
        }
        catch (CardPickupLocationNotExistsException)
        {
            return await HandleException(Code.NOT_FOUND, [_messageManager.GetNotification(FunctionalMessages.CARD_PICKUP_NOT_FOUND)]);
        }
        catch (Exception)
        {
            return await HandleException(Code.SERVICE_UNAVAILABLE, [_messageManager.GetNotification(FunctionalMessages.SERVICE_UNAVAILABLE)]);
        }
    }

    private async Task<ResponseData<CreateTicketSubeResponse, ResponseMessage>> HandleException(Code errorCode, List<string> messages, CreateTicketSubeResponse response = null)
    {
        var responseData = new ResponseData<CreateTicketSubeResponse, ResponseMessage>(
                           code: (int)errorCode,
                           data: response,
                           message: new ResponseMessage()
                           {
                               Message = messages
                           });

        return await Task.FromResult(responseData);
    }
}
