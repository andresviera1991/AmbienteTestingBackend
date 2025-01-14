using MGP.Authentication.CrossCutting.Messages;
using MGP.Authentication.Domain.Interfaces;
using MGP.Authentication.Persistance.DTOs;
using AutoMapper;
using FluentValidation;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using MGP.Authentication.CrossCutting.ResponseData;
using MGP.Authentication.CrossCutting.Helpers;
using System;
using MGP.Authentication.CrossCutting.Exceptions;
using MGP.Authentication.Domain.Models;
using System.Linq;
using System.Collections.Generic;
using MGP.Authentication.CrossCutting.MessagesManager;

namespace MGP.Authentication.Application.UseCase.V1.Authentication.Login;

public class LoginHandler : IRequestHandler<LoginRequest, ResponseData<LoginResponse, ResponseMessage>>
{
    private readonly ILoginService _loginService;
    private readonly IValidator<LoginRequest> _validator;
    private readonly IMapper _mapper;
    private readonly MessageManager _messageManager;

    public LoginHandler(ILoginService loginService,
                        IValidator<LoginRequest> validator,
                        IMapper mapper,
                        MessageManager messageManager)
                       
    {
        _loginService = loginService;
        _validator = validator;
        _mapper = mapper;
        _messageManager = messageManager;
    }

    public async Task<ResponseData<LoginResponse, ResponseMessage>> Handle(LoginRequest request, CancellationToken cancellationToken)
    {
        TokenResponse authAccess = null;
        try
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
            {
                var errorMessages = validationResult.Errors.Select(error => error.ErrorMessage).ToList();
                throw new ParameterNotProviderException(errorMessages);
            }

            authAccess = await _loginService.LoginAsync(_mapper.Map<LoginData>(request));

            var responseData = new ResponseData<LoginResponse, ResponseMessage>(
                                   code: (int)Code.Success,
                                   data: new LoginResponse() { AccessToken = authAccess.AccessToken, RefreshToken = authAccess.RefreshToken },
                                   message: null
                                   );

            return await Task.FromResult(responseData);
        }
        catch (ParameterNotProviderException e)
        {
            return await HandleException(Code.BadRequest, e.Errors);
        }
        catch (EmailException)
        {
            return await HandleException(Code.ServiceUnavailable, [_messageManager.GetNotification(FunctionalMessages.ERROR_SEND_EMAIL_VALIDATE_USER)]);
        }
        catch (UserDeletedException)
        {
            return await HandleException(Code.Unauthorized, [_messageManager.GetNotification(FunctionalMessages.USER_DELETED)]);
        }
        catch (NotFoundException)
        {
            return await HandleException(Code.NotFound, [_messageManager.GetNotification(FunctionalMessages.USER_NOT_EXISTS)]);
        }
        catch (IncorrectCredentialException)
        {
            return await HandleException(Code.Unauthorized, [_messageManager.GetNotification(FunctionalMessages.INCORRECT_PASSWORD)]);
        }
        catch (UserNotActivatedException)
        {
            return await HandleException(Code.Unauthorized, [_messageManager.GetNotification(FunctionalMessages.USER_NOT_ACTIVE)]);
        }
        catch (UserDisabledException)
        {
            return await HandleException(Code.Unauthorized, [_messageManager.GetNotification(FunctionalMessages.USER_DISABLED)]);
        }
        catch (Exception)
        {
            return await HandleException(Code.ServiceUnavailable, [_messageManager.GetNotification(FunctionalMessages.SERVICE_UNAVAILABLE)]);
        }
    }

    private static async Task<ResponseData<LoginResponse, ResponseMessage>> HandleException(Code errorCode, List<string> message)
    {
        var responseData = new ResponseData<LoginResponse, ResponseMessage>(
                           code: (int)errorCode,
                           data: null,
                           message: new ResponseMessage()
                           {
                               Message = message
                           });

        return await Task.FromResult(responseData);
    }
}
