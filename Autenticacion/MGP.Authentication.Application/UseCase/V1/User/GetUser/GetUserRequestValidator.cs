using MGP.Authentication.CrossCutting.Messages;
using MGP.Authentication.CrossCutting.MessagesManager;
using FluentValidation;

namespace MGP.Authentication.Application.UseCase.V1.User.GetUser;

public class GetUserRequestValidator : AbstractValidator<GetUserRequest>
{
    private readonly MessageManager _messageManager;

    public GetUserRequestValidator(MessageManager messageManager)
    {
        _messageManager = messageManager;

        ValidateMandatory();
    }

    private void ValidateMandatory()
    {
        RuleFor(x => x.UserId)
            .NotEmpty()
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.NOT_NULL, nameof(GetUserRequest.UserId)));
    }
}