using FluentValidation;
using MGP.Authentication.CrossCutting.Messages;
using MGP.Authentication.CrossCutting.MessagesManager;
using MGP.Authentication.Domain.Helper;
using Microsoft.Extensions.Options;

namespace MGP.Authentication.Application.UseCase.V1.Authentication.ValidateUser
{
    public class ValidateRegisterValidator : AbstractValidator<ValidateRegisterRequest>
    {
        private readonly MessageManager _messageManager;

        public ValidateRegisterValidator(MessageManager messageManager, IOptions<JwtEmailTokenSettings> jwtEmailSettings)
        {
            _messageManager = messageManager;
            ValidateMandatory();
        }

        private void ValidateMandatory()
        {
            RuleFor(x => x.Token)
            .NotEmpty()
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.NOT_NULL, nameof(ValidateRegisterRequest.Token)));
        }
    }
}
