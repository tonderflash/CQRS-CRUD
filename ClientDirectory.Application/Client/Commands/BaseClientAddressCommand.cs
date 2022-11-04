using ClientDirectory.Application.Client.Dtos;
using ClientDirectory.Application.Enums;
using ClientDirectory.Application.GenericHandler;

namespace ClientDirectory.Application.Client.Commands
{
    public class BaseClientAddressCommand : BaseCommand<AddressDto>
    {
        public string Label { get; set; }
        public string Address { get; set; }
        public AddressesTypes AddressType { get; set; }
        public int ClientId { get; set; }
        public int CityId { get; set; }
        public int CountryId { get; set; }
        public int StateId { get; set; }
    }
}
