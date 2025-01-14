using Flunt.Notifications;
using MediatR;
using MGP.Backoffice.CrossCutting.ResponseData;

namespace MGP.Backoffice.Application.UseCase.V1.Menu
{
    public class GetMenuRequest : Notifiable, IRequest<ResponseData<GetMenuResponse, ResponseMessage>>
    {
        public string Role { get; set; }
        public string Area { get; set; }
    }
}
