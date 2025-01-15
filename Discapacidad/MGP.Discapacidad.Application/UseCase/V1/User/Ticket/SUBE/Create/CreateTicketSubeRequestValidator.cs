using FluentValidation;
using MGP.Discapacidad.Application.UseCase.V1.User.Ticket.CUD.Create;
using MGP.Discapacidad.CrossCutting.Messages;
using MGP.Discapacidad.CrossCutting.MessagesManager;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MGP.Discapacidad.Application.UseCase.V1.User.Ticket.SUBE.Create;

public class CreateTicketSubeRequestValidator : AbstractValidator<CreateTicketSubeRequest>
{
    private readonly MessageManager _messageManager;

    public CreateTicketSubeRequestValidator(MessageManager messageManager)
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
                FunctionalMessages.NOT_NULL, nameof(CreateTicketSubeRequest.UserId)));

        RuleFor(x => x.CudCertificateNumber)
            .NotEmpty()
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.NOT_NULL, nameof(CreateTicketSubeRequest.CudCertificateNumber)));

        RuleFor(x => x.CudExpirationDate)
        .NotEmpty()
        .WithMessage(_messageManager.GetNotification(
            FunctionalMessages.NOT_NULL, nameof(CreateTicketSubeRequest.CudExpirationDate)))
        .Must(date => date >= DateTime.UtcNow.Date)
        .WithMessage(_messageManager.GetNotification(
            FunctionalMessages.INVALID_DATE, nameof(CreateTicketSubeRequest.CudExpirationDate)));
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
