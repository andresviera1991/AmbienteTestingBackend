using FluentValidation;
using MGP.Authentication.CrossCutting.Messages;
using MGP.Authentication.CrossCutting.MessagesManager;
namespace MGP.Authentication.Application.UseCase.V1.User.List.ListUserIds;

public class ListUserIdsByFiltersRequestValidator : AbstractValidator<ListUserIdsByFiltersRequest>
{
    private readonly MessageManager _messageManager;

    public ListUserIdsByFiltersRequestValidator(MessageManager messageManager)
    {
        _messageManager = messageManager;

        ValidateMandatory();
    }

    private void ValidateMandatory()
    {
        RuleFor(x => x)
        .Must(x => !string.IsNullOrEmpty(x.DocumentNumber) || !string.IsNullOrEmpty(x.FullName))
        .WithMessage(_messageManager.GetNotification(
            FunctionalMessages.NOT_NULL, nameof(ListUserIdsByFiltersRequest)));
    }

}
