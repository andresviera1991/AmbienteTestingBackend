using FluentValidation;
using MGP.Authentication.CrossCutting.Messages;
using MGP.Authentication.CrossCutting.MessagesManager;


namespace MGP.Authentication.Application.UseCase.V1.ResetPassword.ValidToken
{
    public class ValidateTokenValidator : AbstractValidator<ValidateTokenRequest>
    {
        private readonly MessageManager _messageManager;

        public ValidateTokenValidator(MessageManager messageManager)
        {
            _messageManager = messageManager;
            ValidateMandatory();
        }

        private void ValidateMandatory()
        {
            RuleFor(x => x.Token)
                .NotEmpty()
                .WithMessage(_messageManager.GetNotification(
                    FunctionalMessages.NOT_NULL, nameof(ValidateTokenRequest.Token)));
        }
    }
}
