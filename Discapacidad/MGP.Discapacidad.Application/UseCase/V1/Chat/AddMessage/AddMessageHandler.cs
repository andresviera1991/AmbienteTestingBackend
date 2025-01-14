using AutoMapper;
using FluentValidation;
using MediatR;
using MGP.Discapacidad.CrossCutting.Excepciones;
using MGP.Discapacidad.CrossCutting.Helpers;
using MGP.Discapacidad.CrossCutting.Messages;
using MGP.Discapacidad.CrossCutting.MessagesManager;
using MGP.Discapacidad.CrossCutting.ResponseData;
using MGP.Discapacidad.Domain.Interfaces;
using MGP.Discapacidad.Persistance.DTOs.Chat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace MGP.Discapacidad.Application.UseCase.V1.Chat.AddMessage;

public class AddMessageHandler : IRequestHandler<AddMessageRequest, ResponseData<AddMessageResponse, ResponseMessage>>
{
    private readonly IChatService _chatService;
    private readonly IValidator<AddMessageRequest> _validator;
    private readonly IMapper _mapper;
    private readonly MessageManager _messageManager;

    public AddMessageHandler(IValidator<AddMessageRequest> validator,
                             IMapper mapper,
                             MessageManager messageManager,
                             IChatService chatService)
    {
        _chatService = chatService;
        _validator = validator;
        _mapper = mapper;
        _messageManager = messageManager;
    }
    public async Task<ResponseData<AddMessageResponse, ResponseMessage>> Handle(AddMessageRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
            {
                var errorMessages = validationResult.Errors.Select(error => error.ErrorMessage).ToList();
                throw new ParameterNotProviderException(errorMessages);
            }

            await _chatService.AddMessageAsync(_mapper.Map<ChatMessageData>(request));

            var responseData = new ResponseData<AddMessageResponse, ResponseMessage>(
                        code: (int)Code.CREATED,
                        data: new AddMessageResponse() { Success = true },
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

    private async Task<ResponseData<AddMessageResponse, ResponseMessage>> HandleException(Code errorCode, List<string> messages, AddMessageResponse response = null)
    {
        var responseData = new ResponseData<AddMessageResponse, ResponseMessage>(
                           code: (int)errorCode,
                           data: response,
                           message: new ResponseMessage()
                           {
                               Message = messages
                           });

        return await Task.FromResult(responseData);
    }
}
