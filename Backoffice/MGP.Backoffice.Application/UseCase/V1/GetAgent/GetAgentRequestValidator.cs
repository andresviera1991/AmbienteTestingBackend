using FluentValidation;
using MGP.Backoffice.CrossCutting.Messages;
using MGP.Backoffice.CrossCutting.MessagesManager;

namespace MGP.Backoffice.Application.UseCase.V1.GetAgent
{
    public class GetAgentRequestValidator : AbstractValidator<GetAgentRequest>
    {
        private readonly MessageManager _messageManager;

        public GetAgentRequestValidator(MessageManager messageManager)
        {
            _messageManager = messageManager;
            ValidateMandatory();
        }

        private void ValidateMandatory()
        {
            RuleFor(x => x.AgentId)
                .NotEmpty()
                .WithMessage(_messageManager.GetNotification(
                    FunctionalErrors.NOT_NULL, nameof(GetAgentRequest.AgentId)));


        }
    }
}

