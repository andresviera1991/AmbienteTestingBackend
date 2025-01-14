using FluentValidation;
using MGP.Discapacidad.CrossCutting.Messages;
using MGP.Discapacidad.CrossCutting.MessagesManager;
using System;

namespace MGP.Discapacidad.Application.UseCase.V1.User.Ticket.SUBE.Get;

public class GetTicketSubeUserRequestValidator : AbstractValidator<GetTicketSubeUserRequest>
{
    private readonly MessageManager _messageManager;

    public GetTicketSubeUserRequestValidator(MessageManager messageManager)
    {
        _messageManager = messageManager;
        ValidateMandatory();
    }

    private void ValidateMandatory()
    {
        RuleFor(x => new { x.TicketId, x.TicketCode })
        .Must(fields => fields.TicketId != Guid.Empty || !string.IsNullOrEmpty(fields.TicketCode))
        .WithMessage(_messageManager.GetNotification(FunctionalMessages.ARGUMENT_NOT_PROVIDER));

        RuleFor(x => x.UserId)
        .NotEmpty()
        .WithMessage(_messageManager.GetNotification(
        FunctionalMessages.NOT_NULL, nameof(GetTicketSubeUserRequest.UserId)));
    }
}
