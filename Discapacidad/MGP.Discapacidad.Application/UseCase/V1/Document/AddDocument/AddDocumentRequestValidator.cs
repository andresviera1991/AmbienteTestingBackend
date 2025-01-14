using FluentValidation;
using MGP.Discapacidad.CrossCutting.Messages;
using MGP.Discapacidad.CrossCutting.MessagesManager;
namespace MGP.Discapacidad.Application.UseCase.V1.Document.AddDocument;

public class AddDocumentRequestValidator : AbstractValidator<AddDocumentRequestList>
{
    private readonly MessageManager _messageManager;

    public AddDocumentRequestValidator(MessageManager messageManager)
    {
        _messageManager = messageManager;
        ValidateMandatory();
    }
    private void ValidateMandatory()
    {
        RuleFor(x => x.TicketId)
          .NotEmpty()
          .WithMessage(_messageManager.GetNotification(
              FunctionalMessages.NOT_NULL, nameof(AddDocumentRequestList.TicketId)));

        RuleFor(x => x.Documents)
          .NotEmpty()
          .WithMessage(_messageManager.GetNotification(
              FunctionalMessages.NOT_NULL, nameof(AddDocumentRequestList.Documents)));
    }
}
