using FluentValidation;
using MGP.Authentication.CrossCutting.Messages;
using MGP.Authentication.CrossCutting.MessagesManager;
namespace MGP.Authentication.Application.UseCase.V1.User.List.ListUsers;

public class ListUsersByFiltersRequestValidator : AbstractValidator<ListUsersByFiltersRequest>
{
    private readonly MessageManager _messageManager;

    public ListUsersByFiltersRequestValidator(MessageManager messageManager)
    {
        _messageManager = messageManager;

        ValidateMandatory();
    }

    private void ValidateMandatory()
    {
        RuleFor(x => x.PageNumber)
         .NotEmpty()
         .WithMessage(_messageManager.GetNotification(
             FunctionalMessages.NOT_NULL, nameof(ListUsersByFiltersRequest.PageNumber)));

        RuleFor(x => x.PageSize)
         .NotEmpty()
         .WithMessage(_messageManager.GetNotification(
             FunctionalMessages.NOT_NULL, nameof(ListUsersByFiltersRequest.PageSize)));
    }
}
