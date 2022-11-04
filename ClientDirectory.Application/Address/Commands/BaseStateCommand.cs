using ClientDirectory.Application.Address.Dtos;
using ClientDirectory.Application.GenericHandler;

namespace ClientDirectory.Application.Address.Commands
{
    public class BaseStateCommand : BaseCommand<StateDto>
    {
        public int CountryId { get; set; }
        public string Name { get; set; }
    }
}
