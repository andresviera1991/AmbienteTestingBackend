using MGP.Discapacidad.CrossCutting.MessagesManager;
using FluentValidation;
using MGP.Discapacidad.CrossCutting.Messages;
using System.Collections.Generic;
using System.Linq;
namespace MGP.Discapacidad.Application.UseCase.V1.User.Ticket.CUD.Create;

public class CreateTicketCudRequestValidator : AbstractValidator<CreateTicketCudRequest>
{
    private readonly MessageManager _messageManager;

    public CreateTicketCudRequestValidator(MessageManager messageManager)
    {
        _messageManager = messageManager;
        ValidateMandatory();
        ValidateUniqueDocumentTypeId();
        ValidateDocumentImageSize();
    }

    private void ValidateMandatory()
    {
        RuleFor(x => x.UserId)
            .NotEmpty()
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.NOT_NULL, nameof(CreateTicketCudRequest.UserId)));

        RuleFor(x => x.Certificate)
            .NotEmpty()
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.NOT_NULL, nameof(CreateTicketCudRequest.Certificate)));

        RuleFor(x => x.CertificateExpansionOptionsId)
            .NotEmpty()
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.NOT_NULL, nameof(CreateTicketCudRequest.CertificateExpansionOptionsId)));

        RuleFor(x => x.LostCertificate)
            .NotEmpty()
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.NOT_NULL, nameof(CreateTicketCudRequest.LostCertificate)));

        RuleFor(x => x.HealthInsurance)
            .NotEmpty()
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.NOT_NULL, nameof(CreateTicketCudRequest.HealthInsurance)));

        RuleFor(x => x.PaySlip)
            .NotEmpty()
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.NOT_NULL, nameof(CreateTicketCudRequest.PaySlip)));

        RuleFor(x => x.SignatureOptionId)
            .NotEmpty()
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.NOT_NULL, nameof(CreateTicketCudRequest.SignatureOptionId)));

        RuleFor(x => x.Documents)
            .Must(docs => docs != null && docs.Count > 0)
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.NOT_NULL, nameof(CreateTicketCudRequest.Documents)));
    }

    private void ValidateUniqueDocumentTypeId()
    {
        RuleFor(x => x.Documents)
            .Must(HaveUniqueDocumentTypeId)
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.DUPLICATE_DOCUMENT_TYPE_ID, nameof(CreateTicketCudRequest.Documents)));
    }

    private static bool HaveUniqueDocumentTypeId(List<CreateTicketDocumentRequest> documents)
    {
        if (documents == null || !documents.Any())
            return true;

        var documentTypeIds = documents.Select(d => d.DocumentTypeId).ToList();
        return documentTypeIds.Distinct().Count() == documentTypeIds.Count;
    }

    private void ValidateDocumentImageSize()
    {

        RuleFor(x => x.Documents)
            .Must(docs => docs.TrueForAll(doc => IsBase64ImageSizeValid(doc.DocumentImage))
            ).WithMessage(_messageManager.GetNotification(
                FunctionalMessages.DOCUMENT_TOO_LARGE, nameof(CreateTicketCudRequest.Documents)));
    }

    private static bool IsBase64ImageSizeValid(string base64Image)
    {
        if (string.IsNullOrEmpty(base64Image))
            return true;

        var base64Data = base64Image.Substring(base64Image.IndexOf(',') + 1);

        return base64Data.Length / 1.33 < 20 * 1024 * 1024;
    }
}