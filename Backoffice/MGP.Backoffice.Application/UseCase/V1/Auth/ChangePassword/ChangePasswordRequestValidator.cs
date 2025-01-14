using FluentValidation;
using MGP.Backoffice.CrossCutting.Messages;
using MGP.Backoffice.CrossCutting.MessagesManager;

namespace MGP.Backoffice.Application.UseCase.V1.Auth.ChangePassword
{
    public class ChangePasswordRequestValidator : AbstractValidator<ChangePasswordRequest>
    {
        private readonly MessageManager _messageManager;

        public ChangePasswordRequestValidator(MessageManager messageManager)
        {
            _messageManager = messageManager;
            ValidateMandatory();
        }

        private void ValidateMandatory()
        {
            RuleFor(x => x.AgentId)
                .NotEmpty()
                .WithMessage(_messageManager.GetNotification(
                    FunctionalErrors.NOT_NULL, nameof(ChangePasswordRequest.AgentId)));

            RuleFor(x => x.CurrentPassword)
                .NotEmpty()
                .WithMessage(_messageManager.GetNotification(
                    FunctionalErrors.NOT_NULL, nameof(ChangePasswordRequest.CurrentPassword)));

            RuleFor(x => x.NewPassword)
                .NotEmpty()
                .WithMessage(_messageManager.GetNotification(
                    FunctionalErrors.NOT_NULL, nameof(ChangePasswordRequest.NewPassword)));
        }
    }
}
