namespace MGP.Location.Persistance.DTOs.Province
{
    public class LocalityDetailDto
    {
        public long LocalityId { get; internal set; }
        public string LocalityName { get; internal set; }
        public long DepartmentId { get; internal set; }
        public string DepartmentName { get; internal set; }
        public int ProvinceId { get; set; }
        public string ProvinceName { get; internal set; }
    }
}
