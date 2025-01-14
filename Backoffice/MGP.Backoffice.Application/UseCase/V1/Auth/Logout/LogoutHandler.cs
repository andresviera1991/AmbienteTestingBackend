using FluentValidation;
using MediatR;
using MGP.Backoffice.CrossCutting.Exceptions;
using MGP.Backoffice.CrossCutting.Helpers;
using MGP.Backoffice.CrossCutting.Messages;
using MGP.Backoffice.CrossCutting.MessagesManager;
using MGP.Backoffice.CrossCutting.ResponseData;
using MGP.Backoffice.Domain.Interface;
using Microsoft.IdentityModel.Tokens;


namespace MGP.Backoffice.Application.UseCase.V1.Auth.Logout
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
