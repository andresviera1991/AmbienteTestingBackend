using FluentValidation;
using MGP.Discapacidad.CrossCutting.Messages;
using MGP.Discapacidad.CrossCutting.MessagesManager;
namespace MGP.Discapacidad.Application.UseCase.V1.Document.RemoveTemplate;
public class RemoveTemplateRequestValidator : AbstractValidator<RemoveTemplateRequest>
{
    private readonly MessageManager _messageManager;

    public RemoveTemplateRequestValidator(MessageManager messageManager)
    {
        _messageManager = messageManager;
        ValidateMandatory();
    }
    private void ValidateMandatory()
    {
        RuleFor(x => x.Id)
          .NotEmpty()
          .WithMessage(_messageManager.GetNotification(
              FunctionalMessages.NOT_NULL, nameof(RemoveTemplateRequest.Id)));
    }
}
