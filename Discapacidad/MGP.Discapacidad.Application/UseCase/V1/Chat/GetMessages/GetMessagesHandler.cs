using FluentValidation;
using MediatR;
using MGP.Discapacidad.CrossCutting.Excepciones;
using MGP.Discapacidad.CrossCutting.Helpers;
using MGP.Discapacidad.CrossCutting.Messages;
using MGP.Discapacidad.CrossCutting.MessagesManager;
using MGP.Discapacidad.CrossCutting.ResponseData;
using MGP.Discapacidad.Domain.Interfaces;
using System.Linq;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace MGP.Discapacidad.Application.UseCase.V1.Chat.GetMessages;

public class GetMessagesHandler : IRequestHandler<GetMessagesRequest, ResponseData<GetMessagesResponse, ResponseMessage>>
{
    private readonly IChatService _chatService;
    private readonly IValidator<GetMessagesRequest> _validator;
    private readonly MessageManager _messageManager;

    public GetMessagesHandler(IValidator<GetMessagesRequest> validator,
                              MessageManager messageManager,
                              IChatService chatService)
    {
        _chatService = chatService;
        _validator = validator;
        _messageManager = messageManager;
    }
    public async Task<ResponseData<GetMessagesResponse, ResponseMessage>> Handle(GetMessagesRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
            {
                var errorMessages = validationResult.Errors.Select(error => error.ErrorMessage).ToList();
                throw new ParameterNotProviderException(errorMessages);
            }

            GetMessagesResponse getMessageResponse = new GetMessagesResponse()
            {
                GetMessageData = await _chatService.GetMessagesAsync(request.TicketId)
            };

            var responseData = new ResponseData<GetMessagesResponse, ResponseMessage>(
                        code: (int)Code.SUCCESS,
                        data: getMessageResponse,
                        message: null
                        );

            return await Task.FromResult(responseData);
        }
        catch (ParameterNotProviderException p)
        {
            return await HandleException(Code.BAD_REQUEST, p.Errors);
        }
        catch (TicketNotFoundException)
        {
            return await HandleException(Code.NOT_FOUND, [_messageManager.GetNotification(FunctionalMessages.TICKET_NOT_FOUND)]);
        }
        catch (Exception)
        {
            return await HandleException(Code.SERVICE_UNAVAILABLE, [_messageManager.GetNotification(FunctionalMessages.SERVICE_UNAVAILABLE)]);
        }
    }

    private async Task<ResponseData<GetMessagesResponse, ResponseMessage>> HandleException(Code errorCode, List<string> messages, GetMessagesResponse response = null)
    {
        var responseData = new ResponseData<GetMessagesResponse, ResponseMessage>(
                           code: (int)errorCode,
                           data: response,
                           message: new ResponseMessage()
                           {
                               Message = messages
                           });

        return await Task.FromResult(responseData);
    }
}
