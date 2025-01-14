using FluentValidation;
using MGP.Discapacidad.CrossCutting.Messages;
using MGP.Discapacidad.CrossCutting.MessagesManager;
namespace MGP.Discapacidad.Application.UseCase.V1.Document.UpdateTemplate;

public class UpdateTemplateRequestValidator : AbstractValidator<UpdateTemplateRequest>
{
    private readonly MessageManager _messageManager;

    public UpdateTemplateRequestValidator(MessageManager messageManager)
    {
        _messageManager = messageManager;
        ValidateMandatory();
    }
    private void ValidateMandatory()
    {
        RuleFor(x => x.Name)
          .NotEmpty()
          .WithMessage(_messageManager.GetNotification(
              FunctionalMessages.NOT_NULL, nameof(UpdateTemplateRequest.Name)));

        RuleFor(x => x.TicketTypeId)
          .NotEmpty()
          .WithMessage(_messageManager.GetNotification(
              FunctionalMessages.NOT_NULL, nameof(UpdateTemplateRequest.TicketTypeId)));

        RuleFor(x => x.Information)
          .NotEmpty()
          .WithMessage(_messageManager.GetNotification(
              FunctionalMessages.NOT_NULL, nameof(UpdateTemplateRequest.Information)));

        RuleFor(x => x.Status)
          .NotEmpty()
          .WithMessage(_messageManager.GetNotification(
              FunctionalMessages.NOT_NULL, nameof(UpdateTemplateRequest.Status)));

    }
}
