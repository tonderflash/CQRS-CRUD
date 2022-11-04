using ClientDirectory.Application.Address.Dtos;
using ClientDirectory.Application.GenericHandler;

namespace ClientDirectory.Application.Address.Commands
{
    public class BaseCountryCommand : BaseCommand<CountryDto>
    {
        public string Name { get; set; }
    }
}
