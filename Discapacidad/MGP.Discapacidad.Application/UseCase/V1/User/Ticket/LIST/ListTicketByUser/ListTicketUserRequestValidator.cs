using FluentValidation;
using MGP.Discapacidad.CrossCutting.Messages;
using MGP.Discapacidad.CrossCutting.MessagesManager;
namespace MGP.Discapacidad.Application.UseCase.V1.User.Ticket.List.ListTicketByUser;
public class ListTicketUserRequestValidator : AbstractValidator<ListTicketUserRequest>
{
    private readonly MessageManager _messageManager;

    public ListTicketUserRequestValidator(MessageManager messageManager)
    {
        _messageManager = messageManager;
        ValidateMandatory();
    }
    private void ValidateMandatory()
    {
        RuleFor(x => x.UserId)
            .NotEmpty()
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.NOT_NULL, nameof(ListTicketUserRequest.UserId)));
    }
}
