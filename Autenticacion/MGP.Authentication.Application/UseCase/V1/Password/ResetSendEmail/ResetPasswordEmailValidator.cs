using FluentValidation;
using MGP.Authentication.CrossCutting.Messages;
using MGP.Authentication.CrossCutting.MessagesManager;

namespace MGP.Authentication.Application.UseCase.V1.Password.ResetSendEmail
{
    public class ResetPasswordEmailValidator : AbstractValidator<ResetPasswordEmailRequest>
    {
        private readonly MessageManager _messageManager;

        public ResetPasswordEmailValidator(MessageManager messageManager)
        {
            _messageManager = messageManager;
            ValidateMandatory();
        }

        private void ValidateMandatory()
        {
            RuleFor(x => x.UserName)
                .NotEmpty()
                .WithMessage(_messageManager.GetNotification(
                    FunctionalMessages.NOT_NULL, nameof(ResetPasswordEmailRequest.UserName)));

        }
    }
}
