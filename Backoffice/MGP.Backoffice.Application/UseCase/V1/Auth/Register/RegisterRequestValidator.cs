using FluentValidation;
using MGP.Backoffice.CrossCutting.Messages;
using MGP.Backoffice.CrossCutting.MessagesManager;

namespace MGP.Backoffice.Application.UseCase.V1.Auth.Register
{
    public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
    {
        private readonly MessageManager _messageManager;

        public RegisterRequestValidator(MessageManager messageManager)
        {
            _messageManager = messageManager;
            ValidateMandatory();
        }

        private void ValidateMandatory()
        {
            RuleFor(x => x.DocumentNumber)
                .NotEmpty()
                .WithMessage(_messageManager.GetNotification(
                    FunctionalErrors.NOT_NULL, nameof(RegisterRequest.DocumentNumber)));

            RuleFor(x => x.LastName)
                .NotEmpty()
                .WithMessage(_messageManager.GetNotification(
                    FunctionalErrors.NOT_NULL, nameof(RegisterRequest.LastName)));

            RuleFor(x => x.FirstName)
                .NotEmpty()
                .WithMessage(_messageManager.GetNotification(
                    FunctionalErrors.NOT_NULL, nameof(RegisterRequest.FirstName)));

            RuleFor(x => x.Email)
                .NotEmpty()
                .WithMessage(_messageManager.GetNotification(
                    FunctionalErrors.NOT_NULL, nameof(RegisterRequest.Email)));

            RuleFor(x => x.EmployeeNumber)
                .NotEmpty()
                .WithMessage(_messageManager.GetNotification(
                    FunctionalErrors.NOT_NULL, nameof(RegisterRequest.EmployeeNumber)));

        }
    }
}
