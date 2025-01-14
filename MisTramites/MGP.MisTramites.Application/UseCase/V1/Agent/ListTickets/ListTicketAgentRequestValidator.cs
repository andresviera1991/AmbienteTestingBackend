using FluentValidation;
using MGP.MisTramites.CrossCutting.Messages;
using MGP.MisTramites.CrossCutting.MessagesManager;
namespace MGP.MisTramites.Application.UseCase.V1.Agent.ListTickets;

public class ListTicketAgentRequestValidator : AbstractValidator<ListTicketAgentRequest>
{
    private readonly MessageManager _messageManager;

    public ListTicketAgentRequestValidator(MessageManager messageManager)
    {
        _messageManager = messageManager;
        ValidateMandatory();
    }

    private void ValidateMandatory()
    {
        RuleFor(x => x.ServiceName)
            .NotEmpty()
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.NOT_NULL, nameof(ListTicketAgentRequest.ServiceName)));

        RuleFor(x => x.PageNumber)
           .NotEmpty()
           .WithMessage(_messageManager.GetNotification(
               FunctionalMessages.NOT_NULL, nameof(ListTicketAgentRequest.PageNumber)));

        RuleFor(x => x.PageSize)
           .NotEmpty()
           .WithMessage(_messageManager.GetNotification(
               FunctionalMessages.NOT_NULL, nameof(ListTicketAgentRequest.PageSize)));
    }
}
