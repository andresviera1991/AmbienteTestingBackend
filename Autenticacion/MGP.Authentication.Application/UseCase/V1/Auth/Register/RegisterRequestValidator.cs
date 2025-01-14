using MGP.Authentication.CrossCutting.Messages;
using MGP.Authentication.CrossCutting.MessagesManager;
using FluentValidation;
using MGP.Authentication.CrossCutting.Helpers;
namespace MGP.Authentication.Application.UseCase.V1.Authentication.Register;

public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
{
    private readonly MessageManager _messageManager;

    public RegisterRequestValidator(MessageManager messageManager)
    {
        _messageManager = messageManager;

        ValidateMandatory();
        ValidateFormat();
        ValidateUnderage();
    }

    private void ValidateMandatory()
    {
        RuleFor(x => x.Person.Name)
            .NotEmpty()
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.NOT_NULL, nameof(RegisterRequest.Person.Name)));

        RuleFor(x => x.Person.DocumentNumber)
            .NotEmpty()
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.NOT_NULL, nameof(RegisterRequest.Person.DocumentNumber)));

        RuleFor(x => x.Person.LastName)
            .NotEmpty()
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.NOT_NULL, nameof(RegisterRequest.Person.LastName)));

        RuleFor(x => x.Password)
            .NotEmpty()
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.NOT_NULL, nameof(RegisterRequest.Password)));

        RuleFor(x => x.Email)
            .NotEmpty()
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.NOT_NULL, nameof(RegisterRequest.Email)));

        RuleFor(x => x.Person.BirthDate)
            .NotEmpty()
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.NOT_NULL, nameof(RegisterRequest.Person.BirthDate)));

        RuleFor(x => x.Person.PhoneNumber.Number)
            .NotEmpty()
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.NOT_NULL, "Number"));

        RuleFor(x => x.Person.Address.Street)
            .NotEmpty()
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.NOT_NULL, nameof(RegisterRequest.Person.Address.Street)));

        RuleFor(x => x.Person.Address.StreetNumber)
            .NotEmpty()
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.NOT_NULL, nameof(RegisterRequest.Person.Address.StreetNumber)));

        RuleFor(x => x.Person.GenderId)
            .NotEmpty()
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.NOT_NULL, nameof(RegisterRequest.Person.GenderId)));

        RuleFor(x => x.Person.Address.LocalityId)
            .NotEmpty()
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.NOT_NULL, nameof(RegisterRequest.Person.Address.LocalityId)));
    }

    private void ValidateFormat()
    {
        RuleFor(x => x.Email)
            .EmailAddress()
            .When(x => !string.IsNullOrEmpty(x.Email))
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.INVALID_FORMAT, nameof(RegisterRequest.Email)));
    }

    private void ValidateUnderage()
    {
        RuleFor(x => x.Person.Parent)
            .NotEmpty()
            .When(x => CommonHelper.IsUnderage(x.Person.BirthDate))
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.NOT_NULL, nameof(RegisterRequest.Person.Parent)));

        RuleFor(x => x.Person.Parent.DocumentNumber)
            .NotEmpty()
            .When(x => CommonHelper.IsUnderage(x.Person.BirthDate) && x.Person.Parent != null)
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.NOT_NULL, nameof(RegisterRequest.Person.Parent.DocumentNumber)));

        RuleFor(x => x.Person.Parent.Name)
            .NotEmpty()
            .When(x => CommonHelper.IsUnderage(x.Person.BirthDate) && x.Person.Parent != null)
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.NOT_NULL, nameof(RegisterRequest.Person.Parent.Name)));

        RuleFor(x => x.Person.Parent.LastName)
            .NotEmpty()
            .When(x => CommonHelper.IsUnderage(x.Person.BirthDate) && x.Person.Parent != null)
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.NOT_NULL, nameof(RegisterRequest.Person.Parent.LastName)));

    }
}