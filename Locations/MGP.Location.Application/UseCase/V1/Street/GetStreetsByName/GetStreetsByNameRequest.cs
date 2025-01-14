using Flunt.Notifications;
using MediatR;
using MGP.Location.CrossCutting.ResponseData;

namespace MGP.Location.Application.UseCase.V1.Street.GetStreetsByName
{
    public class GetStreetsByNameRequest : Notifiable, IRequest<ResponseData<GetStreetsByNameResponseList, ResponseMessage>>
    {
        public long LocalityId { get; set; }
        public string Name { get; set; }
    }
}
