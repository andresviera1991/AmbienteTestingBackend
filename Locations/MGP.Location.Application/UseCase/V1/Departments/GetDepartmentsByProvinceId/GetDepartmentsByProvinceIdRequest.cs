using Flunt.Notifications;
using MediatR;
using MGP.Location.CrossCutting.ResponseData;

namespace MGP.Location.Application.UseCase.V1.Departments.GetDepartmentsByProvinceId
{
    public class GetDepartmentsByProvinceIdRequest : Notifiable, IRequest<ResponseData<GetDepartmentsByProvinceIdResponseList, ResponseMessage>>
    {
        public int ProvinceId { get; set; }
    }
}
