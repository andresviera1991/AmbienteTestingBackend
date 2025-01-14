using FluentValidation;
using MGP.Authentication.CrossCutting.Messages;
using MGP.Authentication.CrossCutting.MessagesManager;

namespace MGP.Authentication.Application.UseCase.V1.Authentication.Logout
{
    public class LogoutValidator : AbstractValidator<LogoutRequest>
    {
        private readonly MessageManager _messageManager;

        public LogoutValidator(MessageManager messageManager)
        {
            _messageManager = messageManager;
            ValidateMandatory();
        }

        private void ValidateMandatory()
        {
            RuleFor(x => x.RefreshToken)
                .NotEmpty()
                .WithMessage(_messageManager.GetNotification(
                    FunctionalMessages.NOT_NULL, nameof(LogoutRequest.RefreshToken)));
        }
    }
}
