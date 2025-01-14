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
namespace MGP.Discapacidad.Application.UseCase.V1.User.Ticket.List.ListTicketByUser;

public class ListTicketUserHandler : IRequestHandler<ListTicketUserRequest, ResponseData<ListTicketData[], ResponseMessage>>
{

    private readonly ITicketService _TicketService;
    private readonly IValidator<ListTicketUserRequest> _validator;
    private readonly MessageManager _messageManager;

    public ListTicketUserHandler(ITicketService TicketService,
                                 IValidator<ListTicketUserRequest> validator,
                                 MessageManager messageManager)
    {
        _TicketService = TicketService;
        _validator = validator;
        _messageManager = messageManager;
    }

    public async Task<ResponseData<ListTicketData[], ResponseMessage>> Handle(ListTicketUserRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);
            if (!validationResult.IsValid)
            {
                var errorMessages = validationResult.Errors.Select(error => error.ErrorMessage).ToList();
                throw new ParameterNotProviderException(errorMessages);
            }

            ListTicketData[] listTicketResponses = await _TicketService.ListTicketsUserAsync(request.UserId);

            var responseData = new ResponseData<ListTicketData[], ResponseMessage>(
                    code: (int)Code.SUCCESS,
                    data: listTicketResponses,
                    message: null);

            return await Task.FromResult(responseData);
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

    private async Task<ResponseData<ListTicketData[], ResponseMessage>> HandleException(Code errorCode, List<string> message, ListTicketData[] response = null)
    {
        var responseData = new ResponseData<ListTicketData[], ResponseMessage>(
                           code: (int)errorCode,
                           data: response,
                           message: new ResponseMessage()
                           {
                               Message = message
                           });

        return await Task.FromResult(responseData);
    }
}
