using AutoMapper;
using FluentValidation;
using MediatR;
using MGP.Discapacidad.CrossCutting.Excepciones;
using MGP.Discapacidad.CrossCutting.Helpers;
using MGP.Discapacidad.CrossCutting.Messages;
using MGP.Discapacidad.CrossCutting.MessagesManager;
using MGP.Discapacidad.CrossCutting.ResponseData;
using MGP.Discapacidad.Domain.interfaces;
using MGP.Discapacidad.Persistance.DTOs.Ticket;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MGP.Discapacidad.Application.UseCase.V1.User.Ticket.PARKING.Create;

public class CreateTicketParkingHandler : IRequestHandler<CreateTicketParkingRequest, ResponseData<CreateTicketParkingResponse, ResponseMessage>>
{
    private readonly ITicketService _ticketService;
    private readonly IMapper _mapper;
    private readonly IValidator<CreateTicketParkingRequest> _validator;
    private readonly MessageManager _messageManager;

    public CreateTicketParkingHandler(ITicketService ticketService,
                                    IMapper mapper,
                                    IValidator<CreateTicketParkingRequest> validator,
                                    MessageManager messageManager)
    {
        _mapper = mapper;
        _ticketService = ticketService;
        _validator = validator;
        _messageManager = messageManager;
    }
    public async Task<ResponseData<CreateTicketParkingResponse, ResponseMessage>> Handle(CreateTicketParkingRequest request, CancellationToken cancellationToken)
    {
        CreateTicketParkingResponse createTicketResponse = null;

        try
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
            {
                var errorMessages = validationResult.Errors.Select(error => error.ErrorMessage).ToList();
                throw new ParameterNotProviderException(errorMessages);
            }

            createTicketResponse = _mapper.Map<CreateTicketParkingResponse>(await _ticketService.CreateTicketParkingAsync(_mapper.Map<CreateTicketParkingData>(request)));

            var responseData = new ResponseData<CreateTicketParkingResponse, ResponseMessage>(
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

    private async Task<ResponseData<CreateTicketParkingResponse, ResponseMessage>> HandleException(Code errorCode, List<string> messages, CreateTicketParkingResponse response = null)
    {
        var responseData = new ResponseData<CreateTicketParkingResponse, ResponseMessage>(
                           code: (int)errorCode,
                           data: response,
                           message: new ResponseMessage()
                           {
                               Message = messages
                           });

        return await Task.FromResult(responseData);
    }
}
