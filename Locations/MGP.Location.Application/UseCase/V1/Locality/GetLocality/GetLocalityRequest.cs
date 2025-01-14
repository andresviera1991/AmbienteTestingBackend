using Flunt.Notifications;
using MediatR;
using MGP.Location.CrossCutting.ResponseData;

namespace MGP.Location.Application.UseCase.V1.Locality.GetLocality
{
    public class GetLocalityRequest : Notifiable, IRequest<ResponseData<GetLocalityResponse, ResponseMessage>>
    {
        public long Id { get; set; }
    }
}
