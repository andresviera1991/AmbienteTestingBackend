using AutoMapper;
using FluentValidation;
using MediatR;
using MGP.Backoffice.CrossCutting.Helpers;
using MGP.Backoffice.CrossCutting.Messages;
using MGP.Backoffice.CrossCutting.Exceptions;
using MGP.Backoffice.CrossCutting.MessagesManager;
using MGP.Backoffice.CrossCutting.ResponseData;
using MGP.Backoffice.Domain.Interface;

namespace MGP.Backoffice.Application.UseCase.V1.NextAvailableAgent
{
    public class NextAvailableAgentHandler : IRequestHandler<NextAvailableAgentRequest, ResponseData<NextAvailableAgentResponse, ResponseMessage>>
    {
        private readonly IUserService _userService;
        private readonly IValidator<NextAvailableAgentRequest> _validator;
        private readonly IMapper _mapper;
        private readonly MessageManager _messageManager;

        public NextAvailableAgentHandler(IUserService userService,
                            IValidator<NextAvailableAgentRequest> validator,
                            IMapper mapper,
                            MessageManager messageManager)

        {
            _userService = userService;
            _validator = validator;
            _mapper = mapper;
            _messageManager = messageManager;
        }

        public async Task<ResponseData<NextAvailableAgentResponse, ResponseMessage>> Handle(NextAvailableAgentRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var validationResult = await _validator.ValidateAsync(request, cancellationToken);

                if (!validationResult.IsValid)
                {
                    var errorMessages = validationResult.Errors.Select(error => error.ErrorMessage).ToList();
                    throw new ParameterNotProviderException(errorMessages);
                }

                NextAvailableAgentResponse agent = _mapper.Map<NextAvailableAgentResponse>(await _userService.NextAvailableAgent(request.TicketType, request.Area));
                
                var responseData = new ResponseData<NextAvailableAgentResponse, ResponseMessage>(
                                       code: (int)Code.Success,
                                       data: agent,
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
                return await HandleException(Code.NotFound, [_messageManager.GetNotification(FunctionalErrors.NOT_FOUND)]);
            }        
            catch (Exception)
            {
                return await HandleException(Code.ServiceUnavailable, [_messageManager.GetNotification(FunctionalErrors.SERVICE_UNAVAILABLE)]);
            }
        }

        private static async Task<ResponseData<NextAvailableAgentResponse, ResponseMessage>> HandleException(Code errorCode, List<string> message)
        {
            var responseData = new ResponseData<NextAvailableAgentResponse, ResponseMessage>(
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