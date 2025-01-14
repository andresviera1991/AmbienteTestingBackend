using Flunt.Notifications;
using MediatR;
using MGP.Location.CrossCutting.ResponseData;

namespace MGP.Location.Application.UseCase.V1.Locality.GetLocalitiesByDepartmentId
{
    public class GetLocalitiesByDepartmentIdRequest : Notifiable, IRequest<ResponseData<GetLocalitiesByDepartmentIdResponseList, ResponseMessage>>
    {
        public int DepartmentId { get; set; }
    }
}
