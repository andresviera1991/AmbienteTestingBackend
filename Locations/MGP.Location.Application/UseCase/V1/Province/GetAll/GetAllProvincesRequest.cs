using Flunt.Notifications;
using MediatR;
using MGP.Location.CrossCutting.ResponseData;

namespace MGP.Location.Application.UseCase.V1.Province.GetAll
{
    public class GetAllProvincesRequest : Notifiable, IRequest<ResponseData<GetAllProvincesResponseList, ResponseMessage>>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public string Source { get; set; }
        public string Category { get; set; }
        public double CentroidLon { get; set; }
        public double CentroidLat { get; set; }
        public string IsoId { get; set; }
        public string IsoName { get; set; }
    }
}
