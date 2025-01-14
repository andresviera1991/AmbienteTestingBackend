using FluentValidation;
using MediatR;
using MGP.Discapacidad.CrossCutting.Excepciones;
using MGP.Discapacidad.CrossCutting.Helpers;
using MGP.Discapacidad.CrossCutting.Messages;
using MGP.Discapacidad.CrossCutting.MessagesManager;
using MGP.Discapacidad.CrossCutting.ResponseData;
using MGP.Discapacidad.Domain.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace MGP.Discapacidad.Application.UseCase.V1.User.Ticket.Update;

public class CancelTicketHandler : IRequestHandler<CancelTicketRequest, ResponseData<CancelTicketResponse, ResponseMessage>>
{
    private readonly ITicketService _TicketService;
    private readonly IValidator<CancelTicketRequest> _validator;
    private readonly MessageManager _messageManager;

    public CancelTicketHandler(ITicketService TicketService,
                               IValidator<CancelTicketRequest> validator,
                               MessageManager messageManager)
    {
        _TicketService = TicketService;
        _validator = validator;
        _messageManager = messageManager;
    }

    public async Task<ResponseData<CancelTicketResponse, ResponseMessage>> Handle(CancelTicketRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
            {
                var errorMessages = validationResult.Errors.Select(error => error.ErrorMessage).ToList();
                throw new ParameterNotProviderException(errorMessages);
            }

            await _TicketService.CancelTicketAsync(request.UserId, request.TicketId);

            var responseData = new ResponseData<CancelTicketResponse, ResponseMessage>(
                       code: (int)Code.SUCCESS,
                       data: new CancelTicketResponse() { Success = true },
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

    private async Task<ResponseData<CancelTicketResponse, ResponseMessage>> HandleException(Code errorCode, List<string> message, CancelTicketResponse response = null)
    {
        var responseData = new ResponseData<CancelTicketResponse, ResponseMessage>(
                           code: (int)errorCode,
                           data: response,
                           message: new ResponseMessage()
                           {
                               Message = message
                           });

        return await Task.FromResult(responseData);
    }
}
