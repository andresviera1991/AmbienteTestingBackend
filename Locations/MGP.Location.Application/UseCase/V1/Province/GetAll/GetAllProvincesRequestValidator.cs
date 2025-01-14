using FluentValidation;
using MGP.Location.CrossCutting.MessagesManager;

namespace MGP.Location.Application.UseCase.V1.Province.GetAll
{
    public class GetAllProvincesRequestValidator : AbstractValidator<GetAllProvincesRequest>
    {
        private readonly MessageManager _messageManager;
        public GetAllProvincesRequestValidator(MessageManager messageManager)
        {
            _messageManager = messageManager;
        }

        
    }
}