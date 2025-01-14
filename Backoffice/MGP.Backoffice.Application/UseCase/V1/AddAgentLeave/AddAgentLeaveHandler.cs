using AutoMapper;
using FluentValidation;
using MediatR;
using MGP.Backoffice.CrossCutting.Helpers;
using MGP.Backoffice.CrossCutting.Messages;
using MGP.Backoffice.CrossCutting.Exceptions;
using MGP.Backoffice.CrossCutting.MessagesManager;
using MGP.Backoffice.CrossCutting.ResponseData;
using MGP.Backoffice.Domain.Interface;
using MGP.Backoffice.Domain.DTOs;

namespace MGP.Backoffice.Application.UseCase.V1.AddAgentLeave
{
    public class AddAgentLeaveHandler : IRequestHandler<AddAgentLeaveRequest, ResponseData<AddAgentLeaveResponse, ResponseMessage>>
    {
        private readonly IAgentLeaveService _agentLeaveService;
        private readonly IValidator<AddAgentLeaveRequest> _validator;
        private readonly IMapper _mapper;
        private readonly MessageManager _messageManager;

        public AddAgentLeaveHandler(IAgentLeaveService agentLeaveService,
                            IValidator<AddAgentLeaveRequest> validator,
                            IMapper mapper,
                            MessageManager messageManager)
        {
            _agentLeaveService = agentLeaveService;
            _validator = validator;
            _mapper = mapper;
            _messageManager = messageManager;
        }

        public async Task<ResponseData<AddAgentLeaveResponse, ResponseMessage>> Handle(AddAgentLeaveRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var validationResult = await _validator.ValidateAsync(request, cancellationToken);

                if (!validationResult.IsValid)
                {
                    var errorMessages = validationResult.Errors.Select(error => error.ErrorMessage).ToList();
                    throw new ParameterNotProviderException(errorMessages);
                }

                var response = await _agentLeaveService.CreateAgentLeaveAsync(_mapper.Map<AgentLeaveData>(request));

                var responseData = new ResponseData<AddAgentLeaveResponse, ResponseMessage>(
                                       code: (int)Code.Created,
                                       data: _mapper.Map<AddAgentLeaveResponse>(response),
                                       message: null
                                       );

                return await Task.FromResult(responseData);

            }
            catch (ParameterNotProviderException e)
            {
                return await HandleException(Code.BadRequest, e.Errors);
            }
            catch (AgentHasVacationException)
            {
                return await HandleException(Code.BadRequest, [_messageManager.GetNotification(FunctionalErrors.AGENT_LEAVE_ALREADY_EXISTS)]);
            }
            catch (NotFoundException)
            {
                return await HandleException(Code.BadRequest, [_messageManager.GetNotification(FunctionalErrors.NOT_FOUND)]);
            }
            catch (Exception)
            {
                return await HandleException(Code.ServiceUnavailable, [_messageManager.GetNotification(FunctionalErrors.SERVICE_UNAVAILABLE)]);
            }

        }

        private static async Task<ResponseData<AddAgentLeaveResponse, ResponseMessage>> HandleException(Code errorCode, List<string> message)
        {
            var responseData = new ResponseData<AddAgentLeaveResponse, ResponseMessage>(
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
