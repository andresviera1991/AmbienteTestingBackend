using FluentValidation;
using MGP.Location.CrossCutting.Messages;
using MGP.Location.CrossCutting.MessagesManager;

namespace MGP.Location.Application.UseCase.V1.Locality.GetLocalitiesByDepartmentId
{
    public class GetLocalitiesByDepartmentIdRequestValidator : AbstractValidator<GetLocalitiesByDepartmentIdRequest>
    {
        private readonly MessageManager _messageManager;
        public GetLocalitiesByDepartmentIdRequestValidator(MessageManager messageManager)
        {
            _messageManager = messageManager;
            ValidateMandatory();
        }

        private void ValidateMandatory()
        {

            RuleFor(x => x.DepartmentId)
                .NotEmpty()
                .WithMessage(_messageManager.GetNotification(
                    FunctionalErrors.NOT_NULL, nameof(GetLocalitiesByDepartmentIdRequest.DepartmentId)));


        }
    }
}