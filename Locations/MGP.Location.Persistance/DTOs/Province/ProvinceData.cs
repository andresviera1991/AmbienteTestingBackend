namespace MGP.Location.Persistance.DTOs.Province

{
    public class ProvinceData
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
