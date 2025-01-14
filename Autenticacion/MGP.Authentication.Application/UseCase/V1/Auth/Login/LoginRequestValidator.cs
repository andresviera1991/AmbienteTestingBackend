using MGP.Authentication.CrossCutting.Messages;
using MGP.Authentication.CrossCutting.MessagesManager;
using FluentValidation;

namespace MGP.Authentication.Application.UseCase.V1.Authentication.Login
{
    public class LoginRequestValidator : AbstractValidator<LoginRequest>
    {
        private readonly MessageManager _messageManager;

        public LoginRequestValidator(MessageManager messageManager)
        {
            _messageManager = messageManager;
            ValidateMandatory();
        }

        private void ValidateMandatory()
        {
            RuleFor(x => x.UserName)
                .NotEmpty()
                .WithMessage(_messageManager.GetNotification(
                    FunctionalMessages.NOT_NULL, nameof(LoginRequest.Password)));

            RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage(_messageManager.GetNotification(
                    FunctionalMessages.NOT_NULL, nameof(LoginRequest.UserName)));
        }
    }
}

