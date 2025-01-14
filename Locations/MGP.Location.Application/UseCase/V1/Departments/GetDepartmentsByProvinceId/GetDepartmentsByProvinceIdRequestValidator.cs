using FluentValidation;
using MGP.Location.CrossCutting.Messages;
using MGP.Location.CrossCutting.MessagesManager;

namespace MGP.Location.Application.UseCase.V1.Departments.GetDepartmentsByProvinceId
{
    public class GetDepartmentsByProvinceIdRequestValidator : AbstractValidator<GetDepartmentsByProvinceIdRequest>
    {
        private readonly MessageManager _messageManager;
        public GetDepartmentsByProvinceIdRequestValidator(MessageManager messageManager)
        {
            _messageManager = messageManager;
            ValidateMandatory();
        }

        private void ValidateMandatory()
        {

            RuleFor(x => x.ProvinceId)
                .NotEmpty()
                .WithMessage(_messageManager.GetNotification(
                    FunctionalErrors.NOT_NULL, nameof(GetDepartmentsByProvinceIdRequest.ProvinceId)));


        }
    }
}