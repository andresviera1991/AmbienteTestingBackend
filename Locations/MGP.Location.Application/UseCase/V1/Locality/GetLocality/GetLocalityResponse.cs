namespace MGP.Location.Application.UseCase.V1.Locality.GetLocality
{
    public class GetLocalityResponse
    {
        public long LocalityId { get; internal set; }
        public string LocalityName { get; internal set; }
        public long DepartmentId { get; internal set; }
        public string DepartmentName { get; internal set; }
        public int ProvinceId { get; set; }
        public string ProvinceName { get; internal set; }
    }
}
