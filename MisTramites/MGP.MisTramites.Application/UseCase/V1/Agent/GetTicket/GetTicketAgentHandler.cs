using FluentValidation;
using MediatR;
using MGP.MisTramites.CrossCutting.Excepciones;
using MGP.MisTramites.CrossCutting.Exceptions;
using MGP.MisTramites.CrossCutting.Helpers;
using MGP.MisTramites.CrossCutting.Messages;
using MGP.MisTramites.CrossCutting.MessagesManager;
using MGP.MisTramites.CrossCutting.ResponseData;
using MGP.MisTramites.Domain.Interfaces;
namespace MGP.MisTramites.Application.UseCase.V1.Agent.GetTicket;

public class GetTicketAgentHandler : IRequestHandler<GetTicketAgentRequest, ResponseData<object, ResponseMessage>>
{
    private readonly IValidator<GetTicketAgentRequest> _validator;
    private readonly ITicketService _ticketService;
    private readonly MessageManager _messageManager;

    public GetTicketAgentHandler(ITicketService ticketService,
                                 MessageManager messageManager,
                                 IValidator<GetTicketAgentRequest> validator)
    {
        _ticketService = ticketService;
        _messageManager = messageManager;
        _validator = validator;
    }

    public async Task<ResponseData<object, ResponseMessage>> Handle(GetTicketAgentRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
            {
                var errorMessages = validationResult.Errors.Select(error => error.ErrorMessage).ToList();
                throw new ParameterNotProviderException(errorMessages);
            }

            object response = await _ticketService.GetTicketAgentAsync(request.ServiceName, request.TicketTypeId, request.TicketId);

            var responseData = new ResponseData<object, ResponseMessage>(
               code: (int)Code.Success,
               data: response,
               message: null);

            return await Task.FromResult(responseData);
        }
        catch (ParameterNotProviderException p)
        {
            return await HandleException(Code.BadRequest, p.Errors);
        }
        catch (EndpointNotFoundException)
        {
            return await HandleException(Code.NotFound, [_messageManager.GetNotification(FunctionalMessages.ENDPOINT_NOT_FOUND)]);
        }
        catch (TicketNotFoundException)
        {
            return await HandleException(Code.NotFound, [_messageManager.GetNotification(FunctionalMessages.TICKET_NOT_FOUND)]);
        }
        catch (Exception)
        {
            return await HandleException(Code.ServiceUnavailable, [_messageManager.GetNotification(FunctionalMessages.SERVICE_UNAVAILABLE)]);
        }
    }

    private async Task<ResponseData<object, ResponseMessage>> HandleException(Code errorCode, List<string> messages, object response = null)
    {
        var responseData = new ResponseData<object, ResponseMessage>(
                           code: (int)errorCode,
                           data: response,
                           message: new ResponseMessage()
                           {
                               Message = messages
                           });

        return await Task.FromResult(responseData);
    }
}
