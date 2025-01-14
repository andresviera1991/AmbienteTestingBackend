using FluentValidation;
using MGP.Backoffice.CrossCutting.Messages;
using MGP.Backoffice.CrossCutting.MessagesManager;

namespace MGP.Backoffice.Application.UseCase.V1.UpdateAgentLeave
{
    public class UpdateAgentLeaveRequestValidator : AbstractValidator<UpdateAgentLeaveRequest>
    {
        private readonly MessageManager _messageManager;

        public UpdateAgentLeaveRequestValidator(MessageManager messageManager)
        {
            _messageManager = messageManager;
            ValidateMandatory();
        }

        private void ValidateMandatory()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage(_messageManager.GetNotification(
                    FunctionalErrors.NOT_NULL, nameof(UpdateAgentLeaveRequest.Id)));

            RuleFor(x => x.AgentId)
                .NotEmpty()
                .WithMessage(_messageManager.GetNotification(
                    FunctionalErrors.NOT_NULL, nameof(UpdateAgentLeaveRequest.AgentId)));

        }
    }
}

