using FluentValidation;
using MGP.Discapacidad.CrossCutting.Messages;
using MGP.Discapacidad.CrossCutting.MessagesManager;
namespace MGP.Discapacidad.Application.UseCase.V1.Agent.Ticket.PARKING.Update;

public class UpdateTicketParkingRequestValidator : AbstractValidator<UpdateTicketParkingRequest>
{
    private readonly MessageManager _messageManager;

    public UpdateTicketParkingRequestValidator(MessageManager messageManager)
    {
        _messageManager = messageManager;
        ValidateMandatory();
    }
    private void ValidateMandatory()
    {
        RuleFor(x => x.TicketStatusId)
          .NotEmpty()
          .WithMessage(_messageManager.GetNotification(
              FunctionalMessages.NOT_NULL, nameof(UpdateTicketParkingRequest.TicketStatusId)));
    }
}
