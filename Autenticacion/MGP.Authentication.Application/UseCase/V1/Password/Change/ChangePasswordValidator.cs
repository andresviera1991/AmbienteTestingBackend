using FluentValidation;
using MGP.Authentication.CrossCutting.Messages;
using MGP.Authentication.CrossCutting.MessagesManager;

namespace MGP.Authentication.Application.UseCase.V1.Password.Change
{
    public class ChangePasswordValidator : AbstractValidator<ChangePasswordRequest>
    {
        private readonly MessageManager _messageManager;

        public ChangePasswordValidator(MessageManager messageManager)
        {
            _messageManager = messageManager;
            ValidateMandatory();
        }

        private void ValidateMandatory()
        {
            RuleFor(x => x.UserId)
                .NotEmpty()
                .WithMessage(_messageManager.GetNotification(
                    FunctionalMessages.NOT_NULL, nameof(ChangePasswordRequest.UserId)));

            RuleFor(x => x.CurrentPassword)
                .NotEmpty()
                .WithMessage(_messageManager.GetNotification(
                    FunctionalMessages.NOT_NULL, nameof(ChangePasswordRequest.CurrentPassword)));

            RuleFor(x => x.NewPassword)
                .NotEmpty()
                .WithMessage(_messageManager.GetNotification(
                    FunctionalMessages.NOT_NULL, nameof(ChangePasswordRequest.NewPassword)));
        }
    }
}
