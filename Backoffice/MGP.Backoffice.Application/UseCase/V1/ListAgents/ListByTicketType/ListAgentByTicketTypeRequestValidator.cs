using FluentValidation;
using MGP.Backoffice.CrossCutting.Messages;
using MGP.Backoffice.CrossCutting.MessagesManager;
namespace MGP.Backoffice.Application.UseCase.V1.ListAgents.ListByTicketType;

public class ListAgentByTicketTypeRequestValidator : AbstractValidator<ListAgentByTicketTypeRequest>
{
    private readonly MessageManager _messageManager;

    public ListAgentByTicketTypeRequestValidator(MessageManager messageManager)
    {
        _messageManager = messageManager;
        ValidateMandatory();
    }

    private void ValidateMandatory()
    {
        RuleFor(x => x.TicketTypeId)
            .NotEmpty()
            .WithMessage(_messageManager.GetNotification(
                FunctionalErrors.NOT_NULL, nameof(ListAgentByTicketTypeRequest.TicketTypeId)));

    }
}

