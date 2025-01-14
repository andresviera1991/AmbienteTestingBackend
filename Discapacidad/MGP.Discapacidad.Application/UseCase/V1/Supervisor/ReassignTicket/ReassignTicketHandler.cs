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
namespace MGP.Discapacidad.Application.UseCase.V1.Supervisor.ReassignTicket;

public class ReassignTicketHandler : IRequestHandler<ReassignTicketRequest, ResponseData<ReassignTicketResponse, ResponseMessage>>
{
    private readonly ITicketService _ticketService;
    private readonly IValidator<ReassignTicketRequest> _validator;
    private readonly MessageManager _messageManager;
    public ReassignTicketHandler(ITicketService ticketService,
                                 IValidator<ReassignTicketRequest> validator,
                                 MessageManager messageManager)
    {
        _ticketService = ticketService;
        _validator = validator;
        _messageManager = messageManager;
    }

    public async Task<ResponseData<ReassignTicketResponse, ResponseMessage>> Handle(ReassignTicketRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
            {
                var errorMessages = validationResult.Errors.Select(error => error.ErrorMessage).ToList();
                throw new ParameterNotProviderException(errorMessages);
            }

            await _ticketService.ReassignTicketAsync(request.TicketId, request.AgentId, request.SupervisorId);

            var responseData = new ResponseData<ReassignTicketResponse, ResponseMessage>(
                       code: (int)Code.SUCCESS,
                       data: new ReassignTicketResponse() { Success = true },
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

    private async Task<ResponseData<ReassignTicketResponse, ResponseMessage>> HandleException(Code errorCode, List<string> message, ReassignTicketResponse response = null)
    {
        var responseData = new ResponseData<ReassignTicketResponse, ResponseMessage>(
                           code: (int)errorCode,
                           data: response,
                           message: new ResponseMessage()
                           {
                               Message = message
                           });

        return await Task.FromResult(responseData);
    }
}
