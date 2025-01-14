using MGP.Authentication.CrossCutting.MessagesManager;
using FluentValidation;
using MGP.Authentication.CrossCutting.Messages;
using System;
namespace MGP.Authentication.Application.UseCase.V1.User.Update;

public class UpdateUserRequestValidator : AbstractValidator<UpdateUserRequest>
{
    private readonly MessageManager _messageManager;

    public UpdateUserRequestValidator(MessageManager messageManager)
    {
        _messageManager = messageManager;

        ValidateUser();
        ValidateParent();
    }

    private void ValidateUser()
    {
        RuleFor(x => x.UserId)
            .NotEmpty()
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.NOT_NULL, nameof(UpdateUserRequest.UserId)));

        RuleFor(x => x.Person.LastName)
            .NotEmpty()
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.NOT_NULL, nameof(UpdateUserRequest.Person.LastName)))
            .Matches(@"^[^\d]*$") // No permite números
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.INVALID_FORMAT, nameof(UpdateUserRequest.Person.LastName)));

        RuleFor(x => x.Person.Name)
            .NotEmpty()
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.NOT_NULL, nameof(UpdateUserRequest.Person.Name)))
            .Matches(@"^[^\d]*$") // No permite números
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.INVALID_FORMAT, nameof(UpdateUserRequest.Person.Name)));

        RuleFor(x => x.Person.BirthDate)
            .LessThanOrEqualTo(DateTime.Today)
            .NotEmpty()
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.INVALID_DATE, nameof(UpdateUserRequest.Person.BirthDate)));
    }

    private void ValidateParent()
    {
        // Validaciones para cuando la persona es menor de 18 años
        RuleFor(x => x.Person.Parent.LastName)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.PARENT_DATA_REQUIRED, nameof(UpdateUserRequest.Person.Parent.LastName)))
            .Matches(@"^[^\d]*$") 
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.INVALID_FORMAT, nameof(UpdateUserRequest.Person.Parent.LastName)))
            .When(x => x.Person.BirthDate > DateTime.Today.AddYears(-18)); 

        RuleFor(x => x.Person.Parent.Name)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.PARENT_DATA_REQUIRED, nameof(UpdateUserRequest.Person.Parent.Name)))
            .Matches(@"^[^\d]*$")
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.INVALID_FORMAT, nameof(UpdateUserRequest.Person.Parent.Name)))
            .When(x => x.Person.BirthDate > DateTime.Today.AddYears(-18)); 

        RuleFor(x => x.Person.Parent.DocumentNumber)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.PARENT_DATA_REQUIRED, nameof(UpdateUserRequest.Person.Parent.DocumentNumber)))
            .Matches(@"^\d+$") // Solo permite números
            .WithMessage(_messageManager.GetNotification(
                FunctionalMessages.INVALID_FORMAT, nameof(UpdateUserRequest.Person.Parent.DocumentNumber)))
            .When(x => x.Person.BirthDate > DateTime.Today.AddYears(-18)); // Solo si es menor de 18 años

        // Elimina validaciones innecesarias para mayores de 18 años.
    }


}