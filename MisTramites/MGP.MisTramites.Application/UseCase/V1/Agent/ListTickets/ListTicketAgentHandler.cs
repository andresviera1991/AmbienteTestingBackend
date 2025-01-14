using AutoMapper;
using FluentValidation;
using MediatR;
using MGP.MisTramites.Client.DTOs.Request;
using MGP.MisTramites.Client.DTOs.Response.ListTicket;
using MGP.MisTramites.CrossCutting.Excepciones;
using MGP.MisTramites.CrossCutting.Exceptions;
using MGP.MisTramites.CrossCutting.Helpers;
using MGP.MisTramites.CrossCutting.Messages;
using MGP.MisTramites.CrossCutting.MessagesManager;
using MGP.MisTramites.CrossCutting.ResponseData;
using MGP.MisTramites.Domain.Interfaces;
namespace MGP.MisTramites.Application.UseCase.V1.Agent.ListTickets;
public class ListTicketAgentHandler : IRequestHandler<ListTicketAgentRequest, ResponseData<TicketDataModel, ResponseMessage>>
{
    private readonly IValidator<ListTicketAgentRequest> _validator;
    private readonly ITicketService _ticketService;
    private readonly MessageManager _messageManager;
    private readonly IMapper _mapper;
    public ListTicketAgentHandler(ITicketService ticketService,
                                  MessageManager messageManager,
                                  IValidator<ListTicketAgentRequest> validator,
                                  IMapper mapper)
    {
        _ticketService = ticketService;
        _messageManager = messageManager;
        _validator = validator;
        _mapper = mapper;
    }
    public async Task<ResponseData<TicketDataModel, ResponseMessage>> Handle(ListTicketAgentRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
            {
                var errorMessages = validationResult.Errors.Select(error => error.ErrorMessage).ToList();
                throw new ParameterNotProviderException(errorMessages);
            }

            TicketDataModel response = await _ticketService.ListTicketsAgentAsync(_mapper.Map<FiltersAgentRequestModel>(request));

            var responseData = new ResponseData<TicketDataModel, ResponseMessage>(
               code: (int)Code.Success,
               data: response,
               message: null);

            return await Task.FromResult(responseData);
        }
        catch (ParameterNotProviderException p)
        {
            return await HandleException(Code.BadRequest, p.Errors);
        }
        catch (TicketNotFoundException)
        {
            return await HandleException(Code.NotFound, [_messageManager.GetNotification(FunctionalMessages.TICKET_NOT_FOUND)]);
        }
        catch (EndpointNotFoundException)
        {
            return await HandleException(Code.NotFound, [_messageManager.GetNotification(FunctionalMessages.ENDPOINT_NOT_FOUND)]);
        }
        catch (UserNotFoundException)
        {
            return await HandleException(Code.NotFound, [_messageManager.GetNotification(FunctionalMessages.USER_NOT_FOUND)]);
        }
        catch (Exception)
        {
            return await HandleException(Code.ServiceUnavailable, [_messageManager.GetNotification(FunctionalMessages.SERVICE_UNAVAILABLE)]);
        }
    }
    private async Task<ResponseData<TicketDataModel, ResponseMessage>> HandleException(Code errorCode, List<string> messages, TicketDataModel response = null)
    {
        var responseData = new ResponseData<TicketDataModel, ResponseMessage>(
                           code: (int)errorCode,
                           data: response,
                           message: new ResponseMessage()
                           {
                               Message = messages
                           });

        return await Task.FromResult(responseData);
    }
}
