using FluentValidation;
using MGP.Discapacidad.CrossCutting.Messages;
using MGP.Discapacidad.CrossCutting.MessagesManager;

namespace MGP.Discapacidad.Application.UseCase.V1.Chat.GetMessages;

public class GetMessagesRequestValidator : AbstractValidator<GetMessagesRequest>
{
    private readonly MessageManager _messageManager;

    public GetMessagesRequestValidator(MessageManager messageManager)
    {
        _messageManager = messageManager;
        ValidateMandatory();
    }
    private void ValidateMandatory()
    {
        RuleFor(x => x.TicketId)
            .NotEmpty()
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.NOT_NULL, nameof(GetMessagesRequest.TicketId)));
    }
}
