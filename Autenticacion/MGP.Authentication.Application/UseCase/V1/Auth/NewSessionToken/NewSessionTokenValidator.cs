using FluentValidation;
using MGP.Authentication.Application.UseCase.V1.Authentication.Logout;
using MGP.Authentication.CrossCutting.Messages;
using MGP.Authentication.CrossCutting.MessagesManager;

namespace MGP.Authentication.Application.UseCase.V1.Authentication.RefreshSessionToken
{
    public class NewSessionTokenValidator : AbstractValidator<NewSessionTokenRequest>
    {
        private readonly MessageManager _messageManager;

        public NewSessionTokenValidator(MessageManager messageManager)
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

