using FluentValidation;
using MGP.Discapacidad.CrossCutting.Messages;
using MGP.Discapacidad.CrossCutting.MessagesManager;
using System;

namespace MGP.Discapacidad.Application.UseCase.V1.Agent.Ticket.CUD.Get;

public class GetTicketCudAgentRequestValidator : AbstractValidator<GetTicketCudAgentRequest>
{
    private readonly MessageManager _messageManager;

    public GetTicketCudAgentRequestValidator(MessageManager messageManager)
    {
        _messageManager = messageManager;
        ValidateMandatory();
    }
    private void ValidateMandatory()
    {
        RuleFor(x => new { x.TicketId, x.TicketCode })
        .Must(fields => fields.TicketId != Guid.Empty || !string.IsNullOrEmpty(fields.TicketCode))
        .WithMessage(_messageManager.GetNotification(
        FunctionalMessages.ARGUMENT_NOT_PROVIDER));
    }
}
