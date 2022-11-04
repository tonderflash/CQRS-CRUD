using ClientDirectory.Application.Address.Dtos;
using ClientDirectory.Application.GenericHandler;

namespace ClientDirectory.Application.Address.Commands
{
    public class BaseCityCommand : BaseCommand<CityDto>
    {
        public int StateId { get; set; }
        public string Name { get; set; }
    }
}
