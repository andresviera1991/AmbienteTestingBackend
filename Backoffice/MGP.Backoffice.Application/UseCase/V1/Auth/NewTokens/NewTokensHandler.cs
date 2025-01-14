using FluentValidation;
using MediatR;
using MGP.Backoffice.CrossCutting.Exceptions;
using MGP.Backoffice.CrossCutting.Helpers;
using MGP.Backoffice.CrossCutting.Messages;
using MGP.Backoffice.CrossCutting.MessagesManager;
using MGP.Backoffice.CrossCutting.ResponseData;
using MGP.Backoffice.Domain.Interface;
using MGP.Backoffice.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace MGP.Backoffice.Application.UseCase.V1.Auth.NewTokens
{
    public class NewTokensHandler : IRequestHandler<NewTokensRequest, ResponseData<NewTokensResponse, ResponseMessage>>
    {
        private readonly ILoginService _loginService;
        private readonly IValidator<NewTokensRequest> _validator;
        private readonly MessageManager _messageManager;

        public NewTokensHandler(ILoginService loginService,
                            IValidator<NewTokensRequest> validator,
                            MessageManager messageManager)
        {
            _loginService = loginService;
            _validator = validator;
            _messageManager = messageManager;
        }
        public async Task<ResponseData<NewTokensResponse, ResponseMessage>> Handle(NewTokensRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var validationResult = await _validator.ValidateAsync(request, cancellationToken);

                if (!validationResult.IsValid)
                {
                    var errorMessages = validationResult.Errors.Select(error => error.ErrorMessage).ToList();
                    throw new ParameterNotProviderException(errorMessages);
                }

                TokenResponse tokens = await _loginService.CreateNewSessionTokens(request.RefreshToken);

                var responseData = new ResponseData<NewTokensResponse, ResponseMessage>(
                                               code: (int)Code.Success,
                                               data: new NewTokensResponse() { AccessToken = tokens.AccessToken, RefreshToken = tokens.RefreshToken },
                                               message: null);

                return await Task.FromResult(responseData);
            }
            catch (ParameterNotProviderException e)
            {
                return await HandleException(Code.BadRequest, e.Errors);
            }
            catch (Exception ex) when (ex is DbUpdateException)
            {
                return await HandleException(Code.NotFound, [_messageManager.GetNotification(FunctionalErrors.USER_NOT_EXISTS)]);
            }
            catch (Exception ex) when (ex is SecurityTokenExpiredException || ex is ArgumentException || ex is SecurityTokenSignatureKeyNotFoundException || ex is InvalidRefreshTokenException)
            {
                return await HandleException(Code.Unauthorized, [_messageManager.GetNotification(FunctionalErrors.INVALID_TOKEN)]);
            }
            catch (Exception)
            {
                return await HandleException(Code.ServiceUnavailable, [_messageManager.GetNotification(FunctionalErrors.SERVICE_UNAVAILABLE)]);
            }
        }
        private static async Task<ResponseData<NewTokensResponse, ResponseMessage>> HandleException(Code errorCode, List<string> message)
        {
            var responseData = new ResponseData<NewTokensResponse, ResponseMessage>(
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
