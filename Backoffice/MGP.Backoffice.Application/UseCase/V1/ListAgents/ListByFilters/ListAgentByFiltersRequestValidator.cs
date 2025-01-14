using FluentValidation;
using MGP.Backoffice.CrossCutting.Messages;
using MGP.Backoffice.CrossCutting.MessagesManager;
namespace MGP.Backoffice.Application.UseCase.V1.ListAgents.ListByFilters;

public class ListAgentByFiltersRequestValidator : AbstractValidator<ListAgentByFiltersRequest>
{
    private readonly MessageManager _messageManager;

    public ListAgentByFiltersRequestValidator(MessageManager messageManager)
    {
        _messageManager = messageManager;
        ValidateMandatory();
    }

    private void ValidateMandatory()
    {
        RuleFor(x => x.PageNumber)
            .NotEmpty()
            .WithMessage(_messageManager.GetNotification(
                FunctionalErrors.NOT_NULL, nameof(ListAgentByFiltersRequest.PageNumber)));

        RuleFor(x => x.PageSize)
            .NotEmpty()
            .WithMessage(_messageManager.GetNotification(
                FunctionalErrors.NOT_NULL, nameof(ListAgentByFiltersRequest.PageSize)));
    }
}

