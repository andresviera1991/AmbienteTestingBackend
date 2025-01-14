using FluentValidation;
using MGP.Discapacidad.CrossCutting.Messages;
using MGP.Discapacidad.CrossCutting.MessagesManager;
namespace MGP.Discapacidad.Application.UseCase.V1.Document.AddTemplate;

public class AddTemplateRequestValidator : AbstractValidator<AddTemplateRequest>
{
    private readonly MessageManager _messageManager;

    public AddTemplateRequestValidator(MessageManager messageManager)
    {
        _messageManager = messageManager;
        ValidateMandatory();
    }
    private void ValidateMandatory()
    {
        RuleFor(x => x.Name)
          .NotEmpty()
          .WithMessage(_messageManager.GetNotification(
              FunctionalMessages.NOT_NULL, nameof(AddTemplateRequest.Name)));

        RuleFor(x => x.TicketTypeId)
          .NotEmpty()
          .WithMessage(_messageManager.GetNotification(
              FunctionalMessages.NOT_NULL, nameof(AddTemplateRequest.TicketTypeId)));

        RuleFor(x => x.Information)
          .NotEmpty()
          .WithMessage(_messageManager.GetNotification(
              FunctionalMessages.NOT_NULL, nameof(AddTemplateRequest.Information)));

        RuleFor(x => x.DocumentPDF)
          .NotEmpty()
          .WithMessage(_messageManager.GetNotification(
              FunctionalMessages.NOT_NULL, nameof(AddTemplateRequest.DocumentPDF)));

    }
}
