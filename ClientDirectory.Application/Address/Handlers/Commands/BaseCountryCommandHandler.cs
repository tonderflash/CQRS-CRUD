using AutoMapper;
using ClientDirectory.Application.Address.Commands;
using ClientDirectory.Application.Address.Dtos;
using ClientDirectory.Application.Entities.Address;
using ClientDirectory.Application.GenericHandler;
using ClientDirectory.Application.Interfaces.Address;

namespace ClientDirectory.Application.Address.Handlers.Commands
{
    public class BaseCountryCommandHandler : BaseCommandHandler<BaseCountryCommand, Country, CountryDto>
    {
        public BaseCountryCommandHandler(ICountryCrudService countryCrudService, IMapper mapper) : base(countryCrudService, mapper)
        {
        }
    }
}
