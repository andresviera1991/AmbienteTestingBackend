namespace MGP.Location.Application.UseCase.V1.Street.GetStreetsByName
{
    public class GetStreetsByNameResponse
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public string Source { get; set; }
        public string Category { get; set; }
        public int EndHeightRight { get; set; }
        public int EndHeightLeft { get; set; }
        public int StartHeightRight { get; set; }
        public int StartHeightLeft { get; set; }
    }
}
