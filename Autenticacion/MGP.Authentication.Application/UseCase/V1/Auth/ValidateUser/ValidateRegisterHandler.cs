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

namespace MGP.Authentication.Application.UseCase.V1.Authentication.ValidateUser;

public class ValidateRegisterHandler : IRequestHandler<ValidateRegisterRequest, ResponseData<ValidateRegisterResponse, ResponseMessage>>
{
    private readonly IUserService _registerService;
    private readonly IValidator<ValidateRegisterRequest> _validator;
    private readonly MessageManager _messageManager;


    public ValidateRegisterHandler(IUserService registerService,
                                   IValidator<ValidateRegisterRequest> validator,
                                   MessageManager messageManager)
    {
        _registerService = registerService;
        _validator = validator;
        _messageManager = messageManager;
    }

    public async Task<ResponseData<ValidateRegisterResponse, ResponseMessage>> Handle(ValidateRegisterRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
            {
                var errorMessages = validationResult.Errors.Select(error => error.ErrorMessage).ToList();
                throw new ParameterNotProviderException(errorMessages);
            }

            await _registerService.ValidateUserAsync(request.Token);

            var responseData = new ResponseData<ValidateRegisterResponse, ResponseMessage>(
                               code: (int)Code.Created,
                               data: new ValidateRegisterResponse() { Success = true },
                               message: null
                               );

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
        catch (Exception ex) when (ex is SecurityTokenExpiredException || ex is ArgumentException || ex is SecurityTokenSignatureKeyNotFoundException)
        {
            return await HandleException(Code.Unauthorized, [_messageManager.GetNotification(FunctionalMessages.INVALID_TOKEN)]);
        }
        catch (Exception)
        {
            return await HandleException(Code.ServiceUnavailable, [_messageManager.GetNotification(FunctionalMessages.SERVICE_UNAVAILABLE)]);
        }
    }
    private static async Task<ResponseData<ValidateRegisterResponse, ResponseMessage>> HandleException(Code errorCode, List<string> message)
    {
        var responseData = new ResponseData<ValidateRegisterResponse, ResponseMessage>(
                           code: (int)errorCode,
                           data: null,
                           message: new ResponseMessage()
                           {
                               Message = message
                           });

        return await Task.FromResult(responseData);
    }

}
