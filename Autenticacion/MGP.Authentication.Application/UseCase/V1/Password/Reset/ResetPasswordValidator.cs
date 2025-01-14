using FluentValidation;
using MGP.Authentication.CrossCutting.Messages;
using MGP.Authentication.CrossCutting.MessagesManager;

namespace MGP.Authentication.Application.UseCase.V1.Password.Reset
{
    public class ResetPasswordValidator : AbstractValidator<ResetPasswordRequest>
    {
        private readonly MessageManager _messageManager;

        public ResetPasswordValidator(MessageManager messageManager)
        {
            _messageManager = messageManager;
            ValidateMandatory();
        }

        private void ValidateMandatory()
        {
            RuleFor(x => x.Token)
                .NotEmpty()
                .WithMessage(_messageManager.GetNotification(
                    FunctionalMessages.NOT_NULL, nameof(ResetPasswordRequest.Token)));

            RuleFor(x => x.NewPassword)
                .NotEmpty()
                .WithMessage(_messageManager.GetNotification(
                    FunctionalMessages.NOT_NULL, nameof(ResetPasswordRequest.NewPassword)));
        }

    }
}
