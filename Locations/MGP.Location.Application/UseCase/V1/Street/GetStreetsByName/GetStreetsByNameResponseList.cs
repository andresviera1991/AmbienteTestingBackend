using System.Collections.Generic;

namespace MGP.Location.Application.UseCase.V1.Street.GetStreetsByName
{
    public class GetStreetsByNameResponseList
    {
        public IEnumerable<GetStreetsByNameResponse> Streets { get; set; }
    }
}
