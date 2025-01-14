using FluentValidation;
using MGP.Backoffice.CrossCutting.MessagesManager;

namespace MGP.Backoffice.Application.UseCase.V1.NextAvailableAgent
{
    public class NextAvailableAgentRequestValidator : AbstractValidator<NextAvailableAgentRequest>
    {
        private readonly MessageManager _messageManager;

        public NextAvailableAgentRequestValidator(MessageManager messageManager)
        {
            _messageManager = messageManager;
            ValidateMandatory();
        }

        private void ValidateMandatory()
        {
        }
    }
}

