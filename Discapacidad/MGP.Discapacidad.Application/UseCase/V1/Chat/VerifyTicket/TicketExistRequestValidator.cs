using FluentValidation;
using MGP.Discapacidad.CrossCutting.Messages;
using MGP.Discapacidad.CrossCutting.MessagesManager;
namespace MGP.Discapacidad.Application.UseCase.V1.Chat.VerifyTicket;

public class TicketExistRequestValidator : AbstractValidator<TicketExistRequest>
{
    private readonly MessageManager _messageManager;
    public TicketExistRequestValidator(MessageManager messageManager)
    {
        _messageManager = messageManager;
        ValidateMandatory();
    }

    private void ValidateMandatory()
    {
        RuleFor(x => x.TicketId)
            .NotEmpty()
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.NOT_NULL, nameof(TicketExistRequest.TicketId)));
    }
}
