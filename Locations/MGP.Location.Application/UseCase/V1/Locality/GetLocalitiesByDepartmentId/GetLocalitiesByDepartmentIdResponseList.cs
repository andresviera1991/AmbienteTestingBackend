using System.Collections.Generic;

namespace MGP.Location.Application.UseCase.V1.Locality.GetLocalitiesByDepartmentId
{
    public class GetLocalitiesByDepartmentIdResponseList
    {
        public IEnumerable<GetLocalitiesByDepartmentIdResponse> Localities { get; set; }
    }
}
