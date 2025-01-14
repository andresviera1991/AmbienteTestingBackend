using FluentValidation;
using MGP.MisTramites.CrossCutting.Messages;
using MGP.MisTramites.CrossCutting.MessagesManager;
namespace MGP.MisTramites.Application.UseCase.V1.User.GetTicket;

public class GetTicketUserRequestValidator : AbstractValidator<GetTicketUserRequest>
{
    private readonly MessageManager _messageManager;

    public GetTicketUserRequestValidator(MessageManager messageManager)
    {
        _messageManager = messageManager;
        ValidateMandatory();
    }

    private void ValidateMandatory()
    {
        RuleFor(x => x.ServiceName)
            .NotEmpty()
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.NOT_NULL, nameof(GetTicketUserRequest.ServiceName)));

        RuleFor(x => x.TicketId)
            .NotEmpty()
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.NOT_NULL, nameof(GetTicketUserRequest.TicketId)));

        RuleFor(x => x.TicketTypeId)
            .NotEmpty()
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.NOT_NULL, nameof(GetTicketUserRequest.TicketTypeId)));
    }
}
