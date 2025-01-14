using FluentValidation;
using MGP.Discapacidad.CrossCutting.Messages;
using MGP.Discapacidad.CrossCutting.MessagesManager;

namespace MGP.Discapacidad.Application.UseCase.V1.Supervisor.ReassignTicket;
public class ReassignTicketRequestValidator : AbstractValidator<ReassignTicketRequest>
{
    private readonly MessageManager _messageManager;

    public ReassignTicketRequestValidator(MessageManager messageManager)
    {
        _messageManager = messageManager;
        ValidateMandatory();
    }
    private void ValidateMandatory()
    {
        RuleFor(x => x.SupervisorId)
           .NotEmpty()
           .WithMessage(_messageManager.GetNotification(
               FunctionalMessages.NOT_NULL, nameof(ReassignTicketRequest.SupervisorId)));

        RuleFor(x => x.AgentId)
          .NotEmpty()
          .WithMessage(_messageManager.GetNotification(
              FunctionalMessages.NOT_NULL, nameof(ReassignTicketRequest.AgentId)));

        RuleFor(x => x.TicketId)
          .NotEmpty()
          .WithMessage(_messageManager.GetNotification(
              FunctionalMessages.NOT_NULL, nameof(ReassignTicketRequest.TicketId)));

    }
}
