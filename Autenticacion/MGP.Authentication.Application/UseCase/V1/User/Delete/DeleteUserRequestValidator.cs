using MGP.Authentication.CrossCutting.MessagesManager;
using FluentValidation;
using MGP.Authentication.CrossCutting.Messages;

namespace MGP.Authentication.Application.UseCase.V1.User.Delete
{
    public class DeleteUserRequestValidator : AbstractValidator<DeleteUserRequest>
    {
        private readonly MessageManager _messageManager;

        public DeleteUserRequestValidator(MessageManager messageManager)
        {
            _messageManager = messageManager;

            ValidateMandatory();
        }

        private void ValidateMandatory()
        {
            RuleFor(x => x.UserId)
                .NotEmpty()
                .WithMessage(_messageManager.GetNotification(
                    FunctionalMessages.NOT_NULL, nameof(DeleteUserRequest.UserId)));
        }
    }
}