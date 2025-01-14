using FluentValidation;
using MGP.MisTramites.CrossCutting.Messages;
using MGP.MisTramites.CrossCutting.MessagesManager;
namespace MGP.MisTramites.Application.UseCase.V1.User.ListTickets;
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
