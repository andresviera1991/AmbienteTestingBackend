using MediatR;
using MGP.Discapacidad.CrossCutting.Helpers;
using MGP.Discapacidad.CrossCutting.Messages;
using MGP.Discapacidad.CrossCutting.MessagesManager;
using MGP.Discapacidad.CrossCutting.ResponseData;
using MGP.Discapacidad.Domain.interfaces;
using System.Collections.Generic;
using System;
using System.Threading;
using System.Threading.Tasks;
namespace MGP.Discapacidad.Application.UseCase.V1.Agent.Ticket.COUNT;

public class CountTicketsByAgentHandler : IRequestHandler<CountTicketsByAgentRequest, ResponseData<CountTicketsByAgentResponse, ResponseMessage>>
{
    private readonly ITicketService _ticketService;
    private readonly MessageManager _messageManager;

    public CountTicketsByAgentHandler(ITicketService ticketService,
                                      MessageManager messageManager)
    {
        _ticketService = ticketService;
        _messageManager = messageManager;
    }

    public async Task<ResponseData<CountTicketsByAgentResponse, ResponseMessage>> Handle(CountTicketsByAgentRequest request, CancellationToken cancellationToken)
    {
        try
        {
            CountTicketsByAgentResponse countTicketsByAgentResponse = new CountTicketsByAgentResponse()
            {
                CountTicketData = await _ticketService.CountTicketByAgentAsync()
            };

            var responseData = new ResponseData<CountTicketsByAgentResponse, ResponseMessage>(
                       code: (int)Code.SUCCESS,
                       data: countTicketsByAgentResponse,
                       message: null);

            return await Task.FromResult(responseData);
        }
        catch (Exception)
        {
            return await HandleException(Code.SERVICE_UNAVAILABLE, [_messageManager.GetNotification(FunctionalMessages.SERVICE_UNAVAILABLE)], null);
        }
    }

    private async Task<ResponseData<CountTicketsByAgentResponse, ResponseMessage>> HandleException(Code errorCode, List<string> message, CountTicketsByAgentResponse response = null)
    {
        var responseData = new ResponseData<CountTicketsByAgentResponse, ResponseMessage>(
                           code: (int)errorCode,
                           data: response,
                           message: new ResponseMessage()
                           {
                               Message = message
                           });

        return await Task.FromResult(responseData);
    }
}
