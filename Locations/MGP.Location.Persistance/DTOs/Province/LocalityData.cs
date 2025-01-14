namespace MGP.Location.Persistance.DTOs.Province

{
    public class LocalityData
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public string Source { get; set; }
        public string Category { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string IsoId { get; set; }
        public string IsoName { get; set; }
        public int ProvinceId { get; set; }
    }
}
