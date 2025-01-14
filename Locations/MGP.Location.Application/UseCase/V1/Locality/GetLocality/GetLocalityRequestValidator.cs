using FluentValidation;
using MGP.Location.CrossCutting.Messages;
using MGP.Location.CrossCutting.MessagesManager;

namespace MGP.Location.Application.UseCase.V1.Locality.GetLocality
{
    public class GetLocalityRequestValidator : AbstractValidator<GetLocalityRequest>
    {
        private readonly MessageManager _messageManager;
        public GetLocalityRequestValidator(MessageManager messageManager)
        {
            _messageManager = messageManager;
            ValidateMandatory();
        }

        private void ValidateMandatory()
        {

            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage(_messageManager.GetNotification(
                    FunctionalErrors.NOT_NULL, nameof(GetLocalityRequest.Id)));


        }
    }
}