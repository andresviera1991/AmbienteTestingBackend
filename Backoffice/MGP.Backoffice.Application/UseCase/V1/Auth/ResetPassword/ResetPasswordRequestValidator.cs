using FluentValidation;
using MGP.Backoffice.CrossCutting.Messages;
using MGP.Backoffice.CrossCutting.MessagesManager;

namespace MGP.Backoffice.Application.UseCase.V1.Auth.ResetPassword
{
    public class ResetPasswordRequestValidator : AbstractValidator<ResetPasswordRequest>
    {
        private readonly MessageManager _messageManager;

        public ResetPasswordRequestValidator(MessageManager messageManager)
        {
            _messageManager = messageManager;
            ValidateMandatory();
        }

        private void ValidateMandatory()
        {
            RuleFor(x => x.EmployeeNumber)
                .NotEmpty()
                .WithMessage(_messageManager.GetNotification(
                    FunctionalErrors.NOT_NULL, nameof(ResetPasswordRequest.EmployeeNumber)));
        }
    }
}
