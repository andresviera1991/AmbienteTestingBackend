using FluentValidation;
using MGP.Backoffice.CrossCutting.Messages;
using MGP.Backoffice.CrossCutting.MessagesManager;

namespace MGP.Backoffice.Application.UseCase.V1.Auth.Logout
{
    public class LogoutRequestValidator : AbstractValidator<LogoutRequest>
    {
        private readonly MessageManager _messageManager;

        public LogoutRequestValidator(MessageManager messageManager)
        {
            _messageManager = messageManager;
            ValidateMandatory();
        }

        private void ValidateMandatory()
        {
            RuleFor(x => x.RefreshToken)
                .NotEmpty()
                .WithMessage(_messageManager.GetNotification(
                    FunctionalErrors.NOT_NULL, nameof(LogoutRequest.RefreshToken)));
        }
    }
}
