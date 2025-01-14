﻿using FluentValidation;
using MGP.Discapacidad.CrossCutting.Messages;
using MGP.Discapacidad.CrossCutting.MessagesManager;
using System;

namespace MGP.Discapacidad.Application.UseCase.V1.User.Ticket.PARKING.Get;

public class GetTicketParkingUserRequestValidator : AbstractValidator<GetTicketParkingUserRequest>
{
    private readonly MessageManager _messageManager;

    public GetTicketParkingUserRequestValidator(MessageManager messageManager)
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
        FunctionalMessages.NOT_NULL, nameof(GetTicketParkingUserRequest.UserId)));
    }
}
