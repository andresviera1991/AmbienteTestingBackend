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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace MGP.Discapacidad.Application.UseCase.V1.Agent.Ticket.PARKING.Update;

public class UpdateTicketParkingHandler : IRequestHandler<UpdateTicketParkingRequest, ResponseData<UpdateTicketParkingResponse, ResponseMessage>>
{
    private readonly ITicketService _TicketService;
    private readonly IValidator<UpdateTicketParkingRequest> _validator;
    private readonly MessageManager _messageManager;
    private readonly IMapper _mapper;

    public UpdateTicketParkingHandler(ITicketService TicketService,
                            IValidator<UpdateTicketParkingRequest> validator,
                            MessageManager messageManager,
                            IMapper mapper)
    {
        _TicketService = TicketService;
        _validator = validator;
        _messageManager = messageManager;
        _mapper = mapper;
    }
    public async Task<ResponseData<UpdateTicketParkingResponse, ResponseMessage>> Handle(UpdateTicketParkingRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
            {
                var errorMessages = validationResult.Errors.Select(error => error.ErrorMessage).ToList();
                throw new ParameterNotProviderException(errorMessages);
            }

            await _TicketService.UpdateTicketParkingAsync(_mapper.Map<UpdateTicketParkingData>(request));

            var responseData = new ResponseData<UpdateTicketParkingResponse, ResponseMessage>(
                       code: (int)Code.SUCCESS,
                       data: new UpdateTicketParkingResponse() { Success = true },
                       message: null);

            return await Task.FromResult(responseData);
        }
        catch (ParameterNotProviderException e)
        {
            return await HandleException(Code.BAD_REQUEST, e.Errors);
        }
        catch (InvalidMedicalCommitteDateException)
        {
            return await HandleException(Code.BAD_REQUEST, [_messageManager.GetNotification(FunctionalMessages.INVALID_DATE)], null);
        }
        catch (TicketStatusNotFoundException)
        {
            return await HandleException(Code.NOT_FOUND, [_messageManager.GetNotification(FunctionalMessages.TICKET_STATUS_NOT_FOUND)], null);
        }
        catch (TicketNotFoundException)
        {
            return await HandleException(Code.NOT_FOUND, [_messageManager.GetNotification(FunctionalMessages.TICKET_NOT_FOUND)], null);
        }
        catch (Exception)
        {
            return await HandleException(Code.SERVICE_UNAVAILABLE, [_messageManager.GetNotification(FunctionalMessages.SERVICE_UNAVAILABLE)], null);
        }
    }

    private async Task<ResponseData<UpdateTicketParkingResponse, ResponseMessage>> HandleException(Code errorCode, List<string> message, UpdateTicketParkingResponse response = null)
    {
        var responseData = new ResponseData<UpdateTicketParkingResponse, ResponseMessage>(
                           code: (int)errorCode,
                           data: response,
                           message: new ResponseMessage()
                           {
                               Message = message
                           });

        return await Task.FromResult(responseData);
    }
}
