using FluentValidation;
using MGP.MisTramites.CrossCutting.Messages;
using MGP.MisTramites.CrossCutting.MessagesManager;
namespace MGP.MisTramites.Application.UseCase.V1.Agent.GetTicket;

public class GetTicketAgentRequestValidator : AbstractValidator<GetTicketAgentRequest>
{
    private readonly MessageManager _messageManager;

    public GetTicketAgentRequestValidator(MessageManager messageManager)
    {
        _messageManager = messageManager;
        ValidateMandatory();
    }

    private void ValidateMandatory()
    {
        RuleFor(x => x.ServiceName)
            .NotEmpty()
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.NOT_NULL, nameof(GetTicketAgentRequest.ServiceName)));

        RuleFor(x => x.TicketId)
            .NotEmpty()
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.NOT_NULL, nameof(GetTicketAgentRequest.TicketId)));

        RuleFor(x => x.TicketTypeId)
            .NotEmpty()
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.NOT_NULL, nameof(GetTicketAgentRequest.TicketTypeId)));
    }
}
