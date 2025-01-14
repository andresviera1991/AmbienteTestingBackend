using MGP.Authentication.CrossCutting.Messages;
using MGP.Authentication.Domain.Interfaces;
using MGP.Authentication.Persistance.DTOs;
using AutoMapper;
using FluentValidation;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using MGP.Authentication.CrossCutting.ResponseData;
using System.Collections.Generic;
using MGP.Authentication.CrossCutting.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using MGP.Authentication.CrossCutting.Exceptions;
using System.Linq;
using MGP.Authentication.CrossCutting.MessagesManager;

namespace MGP.Authentication.Application.UseCase.V1.Authentication.RegisterByAgent;

public class RegisterByAgentHandler : IRequestHandler<RegisterByAgentRequest, ResponseData<RegisterByAgentResponse, ResponseMessage>>
{
    private readonly IUserService _registerService;
    private readonly IValidator<RegisterByAgentRequest> _validator;
    private readonly IMapper _mapper;
    private readonly MessageManager _messageManager;

    public RegisterByAgentHandler(IUserService registerService,
                           IValidator<RegisterByAgentRequest> validator,
                           IMapper mapper,
                           MessageManager messageManager)
    {
        _registerService = registerService;
        _validator = validator;
        _mapper = mapper;
        _messageManager = messageManager;
    }

    public async Task<ResponseData<RegisterByAgentResponse, ResponseMessage>> Handle(RegisterByAgentRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
            {
                var errorMessages = validationResult.Errors.Select(error => error.ErrorMessage).ToList();
                throw new ParameterNotProviderException(errorMessages);
            }

            Guid userId = await _registerService.RegisterByAgentAsync(_mapper.Map<UserData>(request));

            var responseData = new ResponseData<RegisterByAgentResponse, ResponseMessage>(
                               code: (int)Code.Created,
                               data: new RegisterByAgentResponse { UserId = userId },
                               message: null);

            return await Task.FromResult(responseData);
        }
        catch (ParameterNotProviderException e)
        {
            return await HandleException(Code.BadRequest, e.Errors);
        }
        catch (DbUpdateException)
        {
            return await HandleException(Code.Conflict, [_messageManager.GetNotification(FunctionalMessages.USER_ALREADY_EXISTS)]);
        }
        catch (UserAlreadyException e)
        {
            var responseException = new RegisterByAgentResponse() { UserId = e.Id };
            return await HandleException(Code.Conflict, [_messageManager.GetNotification(FunctionalMessages.USER_ALREADY_EXISTS)], responseException);
        }
        catch (Exception)
        {
            return await HandleException(Code.ServiceUnavailable, [_messageManager.GetNotification(FunctionalMessages.SERVICE_UNAVAILABLE)]);
        }

    }
    private static async Task<ResponseData<RegisterByAgentResponse, ResponseMessage>> HandleException(Code errorCode, List<string> message, RegisterByAgentResponse response = null)
    {
        var responseData = new ResponseData<RegisterByAgentResponse, ResponseMessage>(
                           code: (int)errorCode,
                           data: response,
                           message: new ResponseMessage()
                           {
                               Message = message
                           });

        return await Task.FromResult(responseData);
    }
}
