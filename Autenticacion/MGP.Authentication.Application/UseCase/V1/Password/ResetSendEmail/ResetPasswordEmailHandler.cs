using FluentValidation;
using MediatR;
using MGP.Authentication.CrossCutting.Enum;
using MGP.Authentication.CrossCutting.Exceptions;
using MGP.Authentication.CrossCutting.Helpers;
using MGP.Authentication.CrossCutting.Messages;
using MGP.Authentication.CrossCutting.MessagesManager;
using MGP.Authentication.CrossCutting.ResponseData;
using MGP.Authentication.Domain.Interfaces;
using MGP.Authentication.Persistance.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MGP.Authentication.Application.UseCase.V1.Password.ResetSendEmail
{
    public class ResetPasswordEmailHandler : IRequestHandler<ResetPasswordEmailRequest, ResponseData<ResetPasswordEmailResponse, ResponseMessage>>
    {
        private readonly IUserService _userService;
        private readonly IPasswordService _passwordService;
        private readonly IValidator<ResetPasswordEmailRequest> _validator;
        private readonly MessageManager _messageManager;


        public ResetPasswordEmailHandler(
                                IUserService registerService,
                                IValidator<ResetPasswordEmailRequest> validator,
                                MessageManager messageManager,
                                IPasswordService passwordService)
        {
            _userService = registerService;
            _validator = validator;
            _messageManager = messageManager;
            _passwordService = passwordService;
        }

        public async Task<ResponseData<ResetPasswordEmailResponse, ResponseMessage>> Handle(ResetPasswordEmailRequest request, CancellationToken cancellationToken)
        {
            try
            {

                var validationResult = await _validator.ValidateAsync(request, cancellationToken);

                if (!validationResult.IsValid)
                {
                    var errorMessages = validationResult.Errors.Select(error => error.ErrorMessage).ToList();
                    throw new ParameterNotProviderException(errorMessages);
                }

                UserData user = await _userService.GetUserByUserNameAsync(request.UserName);

                await _passwordService.SendEmailResetPasswordAsync(user.Id, user.Email, "Reseteo de Contraseña", EmailTemplateType.RESET_PASSWORD);

                var responseData = new ResponseData<ResetPasswordEmailResponse, ResponseMessage>(
                                   code: (int)Code.Success,
                                   data: new ResetPasswordEmailResponse() { Success = true },
                                   message: new ResponseMessage()
                                   {
                                       Message = [_messageManager.GetNotification(FunctionalMessages.VERIFY_EMAIL)]
                                   });

                return await Task.FromResult(responseData);

            }

            catch (ParameterNotProviderException e)
            {
                return await HandleException(Code.BadRequest, e.Errors, null);
            }
            
            catch (NotFoundException)
            {
                return await HandleException(Code.Success, [_messageManager.GetNotification(FunctionalMessages.VERIFY_EMAIL)], new ResetPasswordEmailResponse() { Success = true });
            }
            catch (EmailException)
            {
                return await HandleException(Code.ServiceUnavailable, [_messageManager.GetNotification(FunctionalMessages.ERROR_SEND_EMAIL_RESET_PASSWORD)], null);
            }
            catch (Exception)
            {
                return await HandleException(Code.ServiceUnavailable, [_messageManager.GetNotification(FunctionalMessages.SERVICE_UNAVAILABLE)], null);
            }
        }

        private static async Task<ResponseData<ResetPasswordEmailResponse, ResponseMessage>> HandleException(Code errorCode, List<string> message, ResetPasswordEmailResponse sendEmailResponse)
        {
            var responseData = new ResponseData<ResetPasswordEmailResponse, ResponseMessage>(
                               code: (int)errorCode,
                               data: sendEmailResponse,
                               message: new ResponseMessage()
                               {
                                   Message = message
                               });

            return await Task.FromResult(responseData);
        }
    }
}
