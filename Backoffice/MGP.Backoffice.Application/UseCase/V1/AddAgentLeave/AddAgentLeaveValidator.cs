using FluentValidation;
using MGP.Backoffice.CrossCutting.Messages;
using MGP.Backoffice.CrossCutting.MessagesManager;

namespace MGP.Backoffice.Application.UseCase.V1.AddAgentLeave
{
    public class AddAgentLeaveRequestValidator : AbstractValidator<AddAgentLeaveRequest>
    {
        private readonly MessageManager _messageManager;

        public AddAgentLeaveRequestValidator(MessageManager messageManager)
        {
            _messageManager = messageManager;
            ValidateMandatory();
            ValidateDates();
        }

        private void ValidateMandatory()
        {
            RuleFor(x => x.StartDate)
                .NotEmpty()
                .WithMessage(_messageManager.GetNotification(
                    FunctionalErrors.NOT_NULL, nameof(AddAgentLeaveRequest.StartDate)));

            RuleFor(x => x.EndDate)
                .NotEmpty()
                .WithMessage(_messageManager.GetNotification(
                    FunctionalErrors.NOT_NULL, nameof(AddAgentLeaveRequest.EndDate)));

            RuleFor(x => x.AgentId)
                .NotEmpty()
                .WithMessage(_messageManager.GetNotification(
                    FunctionalErrors.NOT_NULL, nameof(AddAgentLeaveRequest.AgentId)));
        }

        private void ValidateDates()
        {
            RuleFor(x => x)
                .Must(x => x.StartDate < x.EndDate)
                .WithMessage(_messageManager.GetNotification(
                    FunctionalErrors.INVALID_DATE_RANGE, nameof(AddAgentLeaveRequest.StartDate), nameof(AddAgentLeaveRequest.EndDate)));
        }
    }
}
