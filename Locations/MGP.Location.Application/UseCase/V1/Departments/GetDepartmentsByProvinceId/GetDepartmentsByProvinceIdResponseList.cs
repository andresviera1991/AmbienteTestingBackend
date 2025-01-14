using System.Collections.Generic;

namespace MGP.Location.Application.UseCase.V1.Departments.GetDepartmentsByProvinceId
{
    public class GetDepartmentsByProvinceIdResponseList
    {
        public IEnumerable<GetDepartmentsByProvinceIdResponse> Departments { get; set; }
    }
}
