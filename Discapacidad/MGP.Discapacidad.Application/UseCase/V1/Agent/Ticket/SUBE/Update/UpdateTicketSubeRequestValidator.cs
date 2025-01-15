using FluentValidation;
using MGP.Discapacidad.Application.UseCase.V1.User.Ticket.SUBE.Create;
using MGP.Discapacidad.CrossCutting.Messages;
using MGP.Discapacidad.CrossCutting.MessagesManager;
using System;

namespace MGP.Discapacidad.Application.UseCase.V1.Agent.Ticket.SUBE.Update;

public class UpdateTicketSubeRequestValidator : AbstractValidator<UpdateTicketSubeRequest>
{
    private readonly MessageManager _messageManager;

    public UpdateTicketSubeRequestValidator(MessageManager messageManager)
    {
        _messageManager = messageManager;
        ValidateMandatory();
    }
    private void ValidateMandatory()
    {

        RuleFor(x => x.CardPickupLocationsOptionsId)
          .NotEmpty()
          .WithMessage(_messageManager.GetNotification(
              FunctionalMessages.NOT_NULL, nameof(UpdateTicketSubeRequest.CardPickupLocationsOptionsId)));

        RuleFor(x => x.CudCertificateNumber)
          .NotEmpty()
          .WithMessage(_messageManager.GetNotification(
              FunctionalMessages.NOT_NULL, nameof(UpdateTicketSubeRequest.CudCertificateNumber)));

        RuleFor(x => x.CudExpirationDate)
          .NotEmpty()
          .WithMessage(_messageManager.GetNotification(
              FunctionalMessages.NOT_NULL, nameof(CreateTicketSubeRequest.CudExpirationDate)))
          .Must(date => date >= DateTime.UtcNow.Date)
          .WithMessage(_messageManager.GetNotification(
              FunctionalMessages.INVALID_DATE, nameof(CreateTicketSubeRequest.CudExpirationDate)));

    }
}
