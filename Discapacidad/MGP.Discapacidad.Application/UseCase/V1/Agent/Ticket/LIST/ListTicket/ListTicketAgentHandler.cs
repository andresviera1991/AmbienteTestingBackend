using AutoMapper;
using FluentValidation;
using MediatR;
using MGP.Discapacidad.Application.UseCase.V1.Agent.Ticket.LIST.ListTicket;
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

namespace MGP.Discapacidad.Application.UseCase.V1.Agent.Ticket.List.ListTicketByAgent;

public class ListTicketAgentHandler : IRequestHandler<ListTicketAgentRequest, ResponseData<ListTicketAgentResponse, ResponseMessage>>
{

    private readonly ITicketService _TicketService;
    private readonly IValidator<ListTicketAgentRequest> _validator;
    private readonly MessageManager _messageManager;
    private readonly IMapper _mapper;

    public ListTicketAgentHandler(ITicketService TicketService,
                                    IValidator<ListTicketAgentRequest> validator,
                                    MessageManager messageManager,
                                    IMapper mapper)
    {
        _TicketService = TicketService;
        _validator = validator;
        _messageManager = messageManager;
        _mapper = mapper;
    }

    public async Task<ResponseData<ListTicketAgentResponse, ResponseMessage>> Handle(ListTicketAgentRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);
            if (!validationResult.IsValid)
            {
                var errorMessages = validationResult.Errors.Select(error => error.ErrorMessage).ToList();
                throw new ParameterNotProviderException(errorMessages);
            }

            ListTicketData[] ListTicketByAgentResponses = await _TicketService.ListTicketAgentAsync(_mapper.Map<ListTicketFiltersDto>(request));
            int countTickets = await _TicketService.CountTicketsByfilterAsync(_mapper.Map<ListTicketFiltersDto>(request));

            ListTicketAgentResponse listTicketAgentResponse = new ListTicketAgentResponse()
            {
                ListTicketData = ListTicketByAgentResponses,
                CountTickets = countTickets,
                PageNumber = request.PageNumber
            };


            var responseData = new ResponseData<ListTicketAgentResponse, ResponseMessage>(
                    code: (int)Code.SUCCESS,
                    data: listTicketAgentResponse,
                    message: null);

            return await Task.FromResult(responseData);
        }
        catch (ParameterNotProviderException e)
        {
            return await HandleException(Code.BAD_REQUEST, e.Errors);
        }
        catch (TicketStatusNotFoundException)
        {
            return await HandleException(Code.NOT_FOUND, [_messageManager.GetNotification(FunctionalMessages.TICKET_NOT_FOUND)], null);
        }
        catch (Exception)
        {
            return await HandleException(Code.SERVICE_UNAVAILABLE, [_messageManager.GetNotification(FunctionalMessages.SERVICE_UNAVAILABLE)], null);
        }
    }

    private async Task<ResponseData<ListTicketAgentResponse, ResponseMessage>> HandleException(Code errorCode, List<string> message, ListTicketAgentResponse response = null)
    {
        var responseData = new ResponseData<ListTicketAgentResponse, ResponseMessage>(
                           code: (int)errorCode,
                           data: response,
                           message: new ResponseMessage()
                           {
                               Message = message
                           });

        return await Task.FromResult(responseData);
    }
}
