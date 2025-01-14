using FluentValidation;
using MGP.Location.CrossCutting.MessagesManager;

namespace MGP.Location.Application.UseCase.V1.Street.GetStreetsByName
{
    public class GetStreetsByNameRequestValidator : AbstractValidator<GetStreetsByNameRequest>
    {
        private readonly MessageManager _messageManager;
        public GetStreetsByNameRequestValidator(MessageManager messageManager)
        {
            _messageManager = messageManager;
        }

        
    }
}