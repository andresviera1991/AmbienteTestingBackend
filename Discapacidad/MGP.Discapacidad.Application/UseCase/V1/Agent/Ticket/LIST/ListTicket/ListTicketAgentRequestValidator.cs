using FluentValidation;
using MGP.Discapacidad.CrossCutting.Messages;
using MGP.Discapacidad.CrossCutting.MessagesManager;

namespace MGP.Discapacidad.Application.UseCase.V1.Agent.Ticket.List.ListTicketByAgent;

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
