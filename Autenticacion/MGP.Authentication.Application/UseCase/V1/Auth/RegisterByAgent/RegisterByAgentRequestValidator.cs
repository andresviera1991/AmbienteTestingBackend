using MGP.Authentication.CrossCutting.Messages;
using MGP.Authentication.CrossCutting.MessagesManager;
using FluentValidation;
using MGP.Authentication.CrossCutting.Helpers;

namespace MGP.Authentication.Application.UseCase.V1.Authentication.RegisterByAgent;

public class RegisterByAgentRequestValidator : AbstractValidator<RegisterByAgentRequest>
{
    private readonly MessageManager _messageManager;

    public RegisterByAgentRequestValidator(MessageManager messageManager)
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
                FunctionalMessages.NOT_NULL, nameof(RegisterByAgentRequest.Person.Name)));

        RuleFor(x => x.Person.DocumentNumber)
            .NotEmpty()
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.NOT_NULL, nameof(RegisterByAgentRequest.Person.DocumentNumber)));

        RuleFor(x => x.Person.LastName)
            .NotEmpty()
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.NOT_NULL, nameof(RegisterByAgentRequest.Person.LastName)));


        RuleFor(x => x.Person.BirthDate)
            .NotEmpty()
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.NOT_NULL, nameof(RegisterByAgentRequest.Person.BirthDate)));

        RuleFor(x => x.Person.GenderId)
            .NotEmpty()
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.NOT_NULL, nameof(RegisterByAgentRequest.Person.GenderId)));

    }

    private void ValidateFormat()
    {
        RuleFor(x => x.Email)
            .EmailAddress()
            .When(x => !string.IsNullOrEmpty(x.Email))
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.INVALID_FORMAT, nameof(RegisterByAgentRequest.Email)));
    }

    private void ValidateUnderage()
    {
        RuleFor(x => x.Person.Parent)
            .NotEmpty()
            .When(x => CommonHelper.IsUnderage(x.Person.BirthDate))
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.NOT_NULL, nameof(RegisterByAgentRequest.Person.Parent)));

        RuleFor(x => x.Person.Parent.DocumentNumber)
            .NotEmpty()
            .When(x => CommonHelper.IsUnderage(x.Person.BirthDate) && x.Person.Parent != null)
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.NOT_NULL, nameof(RegisterByAgentRequest.Person.Parent.DocumentNumber)));

        RuleFor(x => x.Person.Parent.Name)
            .NotEmpty()
            .When(x => CommonHelper.IsUnderage(x.Person.BirthDate) && x.Person.Parent != null)
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.NOT_NULL, nameof(RegisterByAgentRequest.Person.Parent.Name)));

        RuleFor(x => x.Person.Parent.LastName)
            .NotEmpty()
            .When(x => CommonHelper.IsUnderage(x.Person.BirthDate) && x.Person.Parent != null)
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.NOT_NULL, nameof(RegisterByAgentRequest.Person.Parent.LastName)));

    }
}