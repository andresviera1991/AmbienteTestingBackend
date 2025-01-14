using AutoMapper;
using FluentValidation;
using MediatR;
using MGP.Discapacidad.CrossCutting.Excepciones;
using MGP.Discapacidad.CrossCutting.Helpers;
using MGP.Discapacidad.CrossCutting.Messages;
using MGP.Discapacidad.CrossCutting.MessagesManager;
using MGP.Discapacidad.CrossCutting.ResponseData;
using MGP.Discapacidad.Domain.interfaces;
using System.Linq;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using MGP.Discapacidad.Persistance.DTOs.Ticket;

namespace MGP.Discapacidad.Application.UseCase.V1.Agent.Ticket.PARKING.Get;

public class GetTicketParkingAgentHandler : IRequestHandler<GetTicketParkingAgentRequest, ResponseData<GetTicketParkingData, ResponseMessage>>
{
    private readonly ITicketService _TicketService;
    private readonly IValidator<GetTicketParkingAgentRequest> _validator;
    private readonly MessageManager _messageManager;
    private readonly IMapper _mapper;

    public GetTicketParkingAgentHandler(ITicketService TicketService,
                                    IValidator<GetTicketParkingAgentRequest> validator,
                                    MessageManager messageManager,
                                    IMapper mapper)
    {
        _TicketService = TicketService;
        _validator = validator;
        _messageManager = messageManager;
        _mapper = mapper;
    }
    public async Task<ResponseData<GetTicketParkingData, ResponseMessage>> Handle(GetTicketParkingAgentRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
            {
                var errorMessages = validationResult.Errors.Select(error => error.ErrorMessage).ToList();
                throw new ParameterNotProviderException(errorMessages);
            }

            GetTicketParkingData getTicketResponse = _mapper.Map<GetTicketParkingData>(await _TicketService.GetTicketParkingAgentAsync(request.TicketId, request.TicketCode));

            var responseData = new ResponseData<GetTicketParkingData, ResponseMessage>(
                       code: (int)Code.SUCCESS,
                       data: getTicketResponse,
                       message: null);

            return await Task.FromResult(responseData);
        }
        catch (ParameterNotProviderException e)
        {
            return await HandleException(Code.BAD_REQUEST, e.Errors);
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
    private static async Task<ResponseData<GetTicketParkingData, ResponseMessage>> HandleException(Code errorCode, List<string> message, GetTicketParkingData response = null)
    {
        var responseData = new ResponseData<GetTicketParkingData, ResponseMessage>(
                           code: (int)errorCode,
                           data: response,
                           message: new ResponseMessage()
                           {
                               Message = message
                           });

        return await Task.FromResult(responseData);
    }

}
