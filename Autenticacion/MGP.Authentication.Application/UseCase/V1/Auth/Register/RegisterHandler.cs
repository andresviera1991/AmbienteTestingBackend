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

namespace MGP.Authentication.Application.UseCase.V1.Authentication.Register;

public class RegisterHandler : IRequestHandler<RegisterRequest, ResponseData<RegisterResponse, ResponseMessage>>
{
    private readonly IUserService _registerService;
    private readonly IValidator<RegisterRequest> _validator;
    private readonly IMapper _mapper;
    private readonly MessageManager _messageManager;
    public RegisterHandler(IUserService registerService,
                           IValidator<RegisterRequest> validator,
                           IMapper mapper,
                           MessageManager messageManager)
    {
        _registerService = registerService;
        _validator = validator;
        _mapper = mapper;
        _messageManager = messageManager;
    }

    public async Task<ResponseData<RegisterResponse, ResponseMessage>> Handle(RegisterRequest request, CancellationToken cancellationToken)
    {
        RegisterResponse response = null;
        try
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
            {
                var errorMessages = validationResult.Errors.Select(error => error.ErrorMessage).ToList();
                throw new ParameterNotProviderException(errorMessages);
            }

            Guid userId = await _registerService.RegisterAsync(_mapper.Map<UserData>(request));

            var responseData = new ResponseData<RegisterResponse, ResponseMessage>(
                               code: (int)Code.Created,
                               data: new RegisterResponse { UserId = userId },
                               message: new ResponseMessage()
                               {
                                   Message = [_messageManager.GetNotification(FunctionalMessages.VERIFY_EMAIL)]
                               });

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
        catch (EmailException)
        {
            return await HandleException(Code.Created, [_messageManager.GetNotification(FunctionalMessages.ERROR_SEND_EMAIL_VALIDATE_USER)], response);
        }
        catch (UserAlreadyException)
        {
            return await HandleException(Code.Conflict, [_messageManager.GetNotification(FunctionalMessages.USER_ALREADY_EXISTS)], response);
        }
        catch (Exception e)
        {
            return await HandleException(Code.ServiceUnavailable, [_messageManager.GetNotification(FunctionalMessages.SERVICE_UNAVAILABLE)]);
        }

    }
    private static async Task<ResponseData<RegisterResponse, ResponseMessage>> HandleException(Code errorCode, List<string> message, RegisterResponse response = null)
    {
        var responseData = new ResponseData<RegisterResponse, ResponseMessage>(
                           code: (int)errorCode,
                           data: response,
                           message: new ResponseMessage()
                           {
                               Message = message
                           });

        return await Task.FromResult(responseData);
    }
}
