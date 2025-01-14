using FluentValidation;
using MediatR;
using MGP.Authentication.CrossCutting.Exceptions;
using MGP.Authentication.CrossCutting.Helpers;
using MGP.Authentication.CrossCutting.Messages;
using MGP.Authentication.CrossCutting.MessagesManager;
using MGP.Authentication.CrossCutting.ResponseData;
using MGP.Authentication.Domain.Interfaces;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MGP.Authentication.Application.UseCase.V1.Authentication.Logout
{
    public class LogoutHandler : IRequestHandler<LogoutRequest, ResponseData<LogoutResponse, ResponseMessage>>
    {

        private readonly ILoginService _loginService;
        private readonly IValidator<LogoutRequest> _validator;
        private readonly MessageManager _messageManager;

        public LogoutHandler(ILoginService loginService,
                            IValidator<LogoutRequest> validator,
                            MessageManager messageManager)
        {
            _loginService = loginService;
            _validator = validator;
            _messageManager = messageManager;
        }
        public async Task<ResponseData<LogoutResponse, ResponseMessage>> Handle(LogoutRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var validationResult = await _validator.ValidateAsync(request, cancellationToken);

                if (!validationResult.IsValid)
                {
                    var errorMessages = validationResult.Errors.Select(error => error.ErrorMessage).ToList();
                    throw new ParameterNotProviderException(errorMessages);
                }

                await _loginService.LogoutAsync(request.RefreshToken);

                var responseData = new ResponseData<LogoutResponse, ResponseMessage>(
                               code: (int)Code.Success,
                               data: new LogoutResponse() { Success = true },
                               message: null);

                return await Task.FromResult(responseData);

            }
            catch (ParameterNotProviderException e)
            {
                return await HandleException(Code.BadRequest, e.Errors);
            }
            catch (NotFoundException)
            {
                return await HandleException(Code.NotFound, [_messageManager.GetNotification(FunctionalMessages.USER_NOT_EXISTS)]);
            }
            catch (Exception ex) when (ex is SecurityTokenExpiredException || ex is ArgumentException || ex is SecurityTokenSignatureKeyNotFoundException || ex is InvalidRefreshTokenException)
            {
                return await HandleException(Code.Unauthorized, [_messageManager.GetNotification(FunctionalMessages.INVALID_TOKEN)]);
            }
            catch (Exception)
            {
                return await HandleException(Code.ServiceUnavailable, [_messageManager.GetNotification(FunctionalMessages.SERVICE_UNAVAILABLE)]);
            }
        }

        private static async Task<ResponseData<LogoutResponse, ResponseMessage>> HandleException(Code errorCode, List<string> message)
        {
            var responseData = new ResponseData<LogoutResponse, ResponseMessage>(
                               code: (int)errorCode,
                               data: null,
                               message: new ResponseMessage()
                               {
                                   Message = message
                               });

            return await Task.FromResult(responseData);
        }
    }
}
