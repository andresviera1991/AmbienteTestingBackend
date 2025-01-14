using AutoMapper;
using FluentValidation;
using MediatR;
using MGP.Backoffice.CrossCutting.Helpers;
using MGP.Backoffice.CrossCutting.Messages;
using MGP.Backoffice.CrossCutting.Exceptions;
using MGP.Backoffice.CrossCutting.MessagesManager;
using MGP.Backoffice.CrossCutting.ResponseData;
using MGP.Backoffice.Domain.Interface;

namespace MGP.Backoffice.Application.UseCase.V1.GetAgentLeave
{
    public class GetAgentLeaveHandler : IRequestHandler<GetAgentLeaveRequest, ResponseData<GetAgentLeaveListResponse, ResponseMessage>>
    {
        private readonly IAgentLeaveService _agentLeaveService;
        private readonly IValidator<GetAgentLeaveRequest> _validator;
        private readonly IMapper _mapper;
        private readonly MessageManager _messageManager;

        public GetAgentLeaveHandler(IAgentLeaveService agentLeaveService,
                            IValidator<GetAgentLeaveRequest> validator,
                            IMapper mapper,
                            MessageManager messageManager)

        {
            _agentLeaveService = agentLeaveService;
            _validator = validator;
            _mapper = mapper;
            _messageManager = messageManager;

        }

        public async Task<ResponseData<GetAgentLeaveListResponse, ResponseMessage>> Handle(GetAgentLeaveRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var validationResult = await _validator.ValidateAsync(request, cancellationToken);

                if (!validationResult.IsValid)
                {
                    var errorMessages = validationResult.Errors.Select(error => error.ErrorMessage).ToList();
                    throw new ParameterNotProviderException(errorMessages);
                }

                var agentsLeave = _mapper.Map<List<GetAgentLeaveResponse>>(await _agentLeaveService.GetAgentLeaveByAgentIdAsync(request.AgentId));
                
                var responseData = new ResponseData<GetAgentLeaveListResponse, ResponseMessage>(
                                       code: (int)Code.Success,
                                       data: new GetAgentLeaveListResponse() { AgentLeave = agentsLeave },
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

        private static async Task<ResponseData<GetAgentLeaveListResponse, ResponseMessage>> HandleException(Code errorCode, List<string> message)
        {
            var responseData = new ResponseData<GetAgentLeaveListResponse, ResponseMessage>(
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