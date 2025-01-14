using AutoMapper;
using FluentValidation;
using MediatR;
using MGP.Backoffice.CrossCutting.Helpers;
using MGP.Backoffice.CrossCutting.Messages;
using MGP.Backoffice.CrossCutting.Exceptions;
using MGP.Backoffice.CrossCutting.MessagesManager;
using MGP.Backoffice.CrossCutting.ResponseData;
using MGP.Backoffice.Domain.DTOs;
using MGP.Backoffice.Domain.Interface;
using Microsoft.EntityFrameworkCore;

namespace MGP.Backoffice.Application.UseCase.V1.Auth.Register
{
    public class RegisterHandler : IRequestHandler<RegisterRequest, ResponseData<RegisterResponse, ResponseMessage>>
    {
        private readonly IUserService _userService;
        private readonly IValidator<RegisterRequest> _validator;
        private readonly IMapper _mapper;
        private readonly MessageManager _messageManager;

        public RegisterHandler(IUserService loginService,
                            IValidator<RegisterRequest> validator,
                            IMapper mapper,
                            MessageManager messageManager)
        {
            _userService = loginService;
            _validator = validator;
            _mapper = mapper;
            _messageManager = messageManager;
        }

        public async Task<ResponseData<RegisterResponse, ResponseMessage>> Handle(RegisterRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var validationResult = await _validator.ValidateAsync(request, cancellationToken);

                if (!validationResult.IsValid)
                {
                    var errorMessages = validationResult.Errors.Select(error => error.ErrorMessage).ToList();
                    throw new ParameterNotProviderException(errorMessages);
                }

                var response = await _userService.RegisterAsync(_mapper.Map<RegisterRequestData>(request));

                var responseData = new ResponseData<RegisterResponse, ResponseMessage>(
                                       code: (int)Code.Created,
                                       data: new RegisterResponse() { Success = response },
                                       message: null);

                return await Task.FromResult(responseData);

            }
            catch (RegisterException e)
            {
                return await HandleException(Code.BadRequest, e.ErrorMessages);
            }
            catch (ParameterNotProviderException e)
            {
                return await HandleException(Code.ServiceUnavailable, e.Errors);
            }
            catch (EmailException)
            {
                return await HandleException(Code.Created, [_messageManager.GetNotification(FunctionalErrors.ERROR_SEND_EMAIL)]);
            }
            catch (RoleNotFoundException)
            {
                return await HandleException(Code.NotFound, [_messageManager.GetNotification(FunctionalErrors.ROLE_NOT_FOUND)]);
            }
            catch (AreaNotFoundException)
            {
                return await HandleException(Code.NotFound, [_messageManager.GetNotification(FunctionalErrors.AREA_NOT_FOUND)]);
            }
            catch (AreaTicketTypeException)
            {
                return await HandleException(Code.BadRequest, [_messageManager.GetNotification(FunctionalErrors.AREA_TICKET_TYPE_ERROR)]);
            }
            catch (DbUpdateException)
            {
                return await HandleException(Code.BadRequest, [_messageManager.GetNotification(FunctionalErrors.USER_ALREADY_EXISTS)]);
            }
            catch (Exception)
            {
                return await HandleException(Code.ServiceUnavailable, [_messageManager.GetNotification(FunctionalErrors.SERVICE_UNAVAILABLE)]);
            }

        }

        private static async Task<ResponseData<RegisterResponse, ResponseMessage>> HandleException(Code errorCode, List<string> message)
        {
            var responseData = new ResponseData<RegisterResponse, ResponseMessage>(
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
