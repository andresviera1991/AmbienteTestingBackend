using AutoMapper;
using FluentValidation;
using MediatR;
using MGP.Backoffice.CrossCutting.Exceptions;
using MGP.Backoffice.CrossCutting.Helpers;
using MGP.Backoffice.CrossCutting.Messages;
using MGP.Backoffice.CrossCutting.MessagesManager;
using MGP.Backoffice.CrossCutting.ResponseData;
using MGP.Backoffice.Domain.Interface;
using MGP.Backoffice.Persistance.DTOs;

namespace MGP.Backoffice.Application.UseCase.V1.Auth.ChangePassword
{
    public class ChangePasswordHandler : IRequestHandler<ChangePasswordRequest, ResponseData<ChangePasswordResponse, ResponseMessage>>
    {

        private readonly ILoginService _loginService;
        private readonly IValidator<ChangePasswordRequest> _validator;
        private readonly MessageManager _messageManager;
        private readonly IMapper _mapper;

        public ChangePasswordHandler(ILoginService loginService,
                                    MessageManager messageManager,
                                    IValidator<ChangePasswordRequest> validator,
                                    IMapper mapper)
        {
            _loginService = loginService;
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

                await _loginService.ChangePasswordAsync(_mapper.Map<ChangePasswordData>(request));

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
