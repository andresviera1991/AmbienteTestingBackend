using FluentValidation;
using MGP.Discapacidad.CrossCutting.Messages;
using MGP.Discapacidad.CrossCutting.MessagesManager;
namespace MGP.Discapacidad.Application.UseCase.V1.Agent.Ticket.CUD.Update;
public class UpdateTicketCudRequestValidator : AbstractValidator<UpdateTicketCudRequest>
{
    private readonly MessageManager _messageManager;

    public UpdateTicketCudRequestValidator(MessageManager messageManager)
    {
        _messageManager = messageManager;
        ValidateMandatory();
    }
    private void ValidateMandatory()
    {
        RuleFor(x => x.TicketId)
          .NotEmpty()
          .WithMessage(_messageManager.GetNotification(
              FunctionalMessages.NOT_NULL, nameof(UpdateTicketCudRequest.TicketId)));

        RuleFor(x => x.TicketStatusId)
          .NotEmpty()
          .WithMessage(_messageManager.GetNotification(
              FunctionalMessages.NOT_NULL, nameof(UpdateTicketCudRequest.TicketStatusId)));

        RuleFor(x => x.CertificateExpansionOptionsId)
          .NotEmpty()
          .WithMessage(_messageManager.GetNotification(
              FunctionalMessages.NOT_NULL, nameof(UpdateTicketCudRequest.CertificateExpansionOptionsId)));

        RuleFor(x => x.SignatureOptionsId)
          .NotEmpty()
          .WithMessage(_messageManager.GetNotification(
              FunctionalMessages.NOT_NULL, nameof(UpdateTicketCudRequest.SignatureOptionsId)));

    }
}
