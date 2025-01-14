using AutoMapper;
using FluentValidation;
using MediatR;
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

namespace MGP.Authentication.Application.UseCase.V1.Password.Change
{
    public class ChangePasswordHandler : IRequestHandler<ChangePasswordRequest, ResponseData<ChangePasswordResponse, ResponseMessage>>
    {

        private readonly IPasswordService _passwordService;
        private readonly IValidator<ChangePasswordRequest> _validator;
        private readonly MessageManager _messageManager;
        private readonly IMapper _mapper;

        public ChangePasswordHandler(IPasswordService resetPasswordService,
                                    MessageManager messageManager,
                                    IValidator<ChangePasswordRequest> validator,
                                    IMapper mapper)
        {
            _passwordService = resetPasswordService;
            _messageManager = messageManager;
            _validator = validator;
            _mapper = mapper;
        }

        public async Task<ResponseData<ChangePasswordResponse, ResponseMessage>> Handle(ChangePasswordRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var validationResult = await _validator.ValidateAsync(request, cancellationToken);

                if (!validationResult.IsValid)
                {
                    var errorMessages = validationResult.Errors.Select(error => error.ErrorMessage).ToList();
                    throw new ParameterNotProviderException(errorMessages);
                }

                await _passwordService.ChangePasswordAsync(_mapper.Map<ChangePasswordData>(request));

                var responseData = new ResponseData<ChangePasswordResponse, ResponseMessage>(
                                   code: (int)Code.Success,
                                   data: new ChangePasswordResponse() { Success = true },
                                   message: null
                                   );

                return await Task.FromResult(responseData);
            }
            catch (ParameterNotProviderException e)
            {
                return await HandleException(Code.BadRequest, e.Errors);
            }
            catch (SamePasswordException)
            {
                return await HandleException(Code.BadRequest, [_messageManager.GetNotification(FunctionalMessages.SAME_PASSWORD)]);
            }
            catch (IncorrectCredentialException)
            {
                return await HandleException(Code.BadRequest, [_messageManager.GetNotification(FunctionalMessages.INCORRECT_PASSWORD)]);
            } 
            catch (Exception)
            {
                return await HandleException(Code.ServiceUnavailable, [_messageManager.GetNotification(FunctionalMessages.SERVICE_UNAVAILABLE)]);
            }
        }

        private static async Task<ResponseData<ChangePasswordResponse, ResponseMessage>> HandleException(Code errorCode, List<string> message)
        {
            var responseData = new ResponseData<ChangePasswordResponse, ResponseMessage>(
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
