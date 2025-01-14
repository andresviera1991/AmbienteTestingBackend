using FluentValidation;
using MGP.Discapacidad.CrossCutting.Messages;
using MGP.Discapacidad.CrossCutting.MessagesManager;
namespace MGP.Discapacidad.Application.UseCase.V1.Chat.AddMessage;

public class AddMessageRequestValidator : AbstractValidator<AddMessageRequest>
{
    private readonly MessageManager _messageManager;

    public AddMessageRequestValidator(MessageManager messageManager)
    {
        _messageManager = messageManager;
        ValidateMandatory();
    }
    private void ValidateMandatory()
    {
        RuleFor(x => x.Message)
            .NotEmpty()
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.NOT_NULL, nameof(AddMessageRequest.Message)));

        RuleFor(x => x.SentAt)
            .NotEmpty()
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.NOT_NULL, nameof(AddMessageRequest.SentAt)));

        RuleFor(x => x.TicketId)
            .NotEmpty()
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.NOT_NULL, nameof(AddMessageRequest.TicketId)));
    }
}
