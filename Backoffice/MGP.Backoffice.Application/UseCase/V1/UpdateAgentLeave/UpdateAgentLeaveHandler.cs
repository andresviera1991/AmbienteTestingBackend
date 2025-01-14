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

namespace MGP.Backoffice.Application.UseCase.V1.UpdateAgentLeave
{
    public class UpdateAgentLeaveHandler : IRequestHandler<UpdateAgentLeaveRequest, ResponseData<UpdateAgentLeaveResponse, ResponseMessage>>
    {
        private readonly IAgentLeaveService _agentLeaveService;
        private readonly IValidator<UpdateAgentLeaveRequest> _validator;
        private readonly IMapper _mapper;
        private readonly MessageManager _messageManager;

        public UpdateAgentLeaveHandler(IAgentLeaveService agentLeaveService,
                            IValidator<UpdateAgentLeaveRequest> validator,
                            IMapper mapper,
                            MessageManager messageManager)

        {
            _agentLeaveService = agentLeaveService;
            _validator = validator;
            _mapper = mapper;
            _messageManager = messageManager;

        }

        public async Task<ResponseData<UpdateAgentLeaveResponse, ResponseMessage>> Handle(UpdateAgentLeaveRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var validationResult = await _validator.ValidateAsync(request, cancellationToken);

                if (!validationResult.IsValid)
                {
                    var errorMessages = validationResult.Errors.Select(error => error.ErrorMessage).ToList();
                    throw new ParameterNotProviderException(errorMessages);
                }

                var agentsLeave = _mapper.Map<UpdateAgentLeaveResponse>(await _agentLeaveService.PatchAgentLeaveAsync(_mapper.Map<AgentLeaveDataToUpdate>(request)));
                
                var responseData = new ResponseData<UpdateAgentLeaveResponse, ResponseMessage>(
                                       code: (int)Code.Success,
                                       data: agentsLeave,
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

        private static async Task<ResponseData<UpdateAgentLeaveResponse, ResponseMessage>> HandleException(Code errorCode, List<string> message)
        {
            var responseData = new ResponseData<UpdateAgentLeaveResponse, ResponseMessage>(
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