using FluentValidation;
using MediatR;
using MGP.Backoffice.CrossCutting.Exceptions;
using MGP.Backoffice.CrossCutting.Helpers;
using MGP.Backoffice.CrossCutting.Messages;
using MGP.Backoffice.CrossCutting.MessagesManager;
using MGP.Backoffice.CrossCutting.ResponseData;
using MGP.Backoffice.Domain.Interface;

namespace MGP.Backoffice.Application.UseCase.V1.Auth.ResetPassword;

public class ResetPasswordHandler : IRequestHandler<ResetPasswordRequest, ResponseData<ResetPasswordResponse, ResponseMessage>>
{

    private readonly ILoginService _loginService;
    private readonly IValidator<ResetPasswordRequest> _validator;
    private readonly MessageManager _messageManager;

    public ResetPasswordHandler(ILoginService loginService,
                                MessageManager messageManager,
                                IValidator<ResetPasswordRequest> validator)
    {
        _loginService = loginService;
        _messageManager = messageManager;
        _validator = validator;
    }

    public async Task<ResponseData<ResetPasswordResponse, ResponseMessage>> Handle(ResetPasswordRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
            {
                var errorMessages = validationResult.Errors.Select(error => error.ErrorMessage).ToList();
                throw new ParameterNotProviderException(errorMessages);
            }

            await _loginService.ResetPasswordAsync(request.EmployeeNumber);

            var responseData = new ResponseData<ResetPasswordResponse, ResponseMessage>(
                               code: (int)Code.Success,
                               data: new ResetPasswordResponse() { Success = true },
                               message: new ResponseMessage()
                               {
                                   Message = [_messageManager.GetNotification(FunctionalErrors.VERIFY_EMAIL)]
                               });

            return await Task.FromResult(responseData);
        }
        catch (ParameterNotProviderException e)
        {
            return await HandleException(Code.BadRequest, e.Errors);
        }
        catch (ChangePasswordException e)
        {
            return await HandleException(Code.BadRequest, e.ErrorMessages);
        }
        catch (IncorrectCredentialException)
        {
            return await HandleException(Code.BadRequest, [_messageManager.GetNotification(FunctionalErrors.INCORRECT_PASSWORD)]);
        }
        catch (Exception)
        {
            return await HandleException(Code.ServiceUnavailable, [_messageManager.GetNotification(FunctionalErrors.SERVICE_UNAVAILABLE)]);
        }
    }

    private static async Task<ResponseData<ResetPasswordResponse, ResponseMessage>> HandleException(Code errorCode, List<string> message)
    {
        var responseData = new ResponseData<ResetPasswordResponse, ResponseMessage>(
                           code: (int)errorCode,
                           data: null,
                           message: new ResponseMessage()
                           {
                               Message = message
                           });

        return await Task.FromResult(responseData);
    }
}
