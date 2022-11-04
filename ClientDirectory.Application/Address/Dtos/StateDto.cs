namespace ClientDirectory.Application.Address.Dtos
{
    public class StateDto
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public string Name { get; set; }
        public List<CityDto> Cities { get; set; }
    }
}