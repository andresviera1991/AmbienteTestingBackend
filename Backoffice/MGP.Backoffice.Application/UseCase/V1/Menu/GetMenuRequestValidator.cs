using FluentValidation;
using MGP.Backoffice.CrossCutting.Messages;
using MGP.Backoffice.CrossCutting.MessagesManager;

namespace MGP.Backoffice.Application.UseCase.V1.Menu;

public class GetMenuRequestValidator : AbstractValidator<GetMenuRequest>
{
    private readonly MessageManager _messageManager;

    public GetMenuRequestValidator(MessageManager messageManager)
    {
        _messageManager = messageManager;
        ValidateMandatory();
    }

    private void ValidateMandatory()
    {
        RuleFor(x => x.Role)
        .NotEmpty()
        .WithMessage(_messageManager.GetNotification(
            FunctionalErrors.NOT_NULL, nameof(GetMenuRequest.Role)));

        RuleFor(x => x.Area)
            .NotEmpty()
            .When(x => x.Role != "ADMIN")
            .WithMessage(_messageManager.GetNotification(
                FunctionalErrors.NOT_NULL, nameof(GetMenuRequest.Area)));
    }
}