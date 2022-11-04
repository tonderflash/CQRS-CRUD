using AutoMapper;
using ClientDirectory.Application.Address.Commands;
using ClientDirectory.Application.Address.Dtos;

namespace ClientDirectory.Application.Address.Mappings
{
    public class AddressMappingProfile : Profile
    {
        public AddressMappingProfile()
        {
            CreateMap<BaseCountryCommand, Entities.Address.Country>();
            CreateMap<BaseStateCommand, Entities.Address.State>();
            CreateMap<BaseCityCommand, Entities.Address.City>();

            CreateMap<Entities.Address.Country, CountryDto>();
            CreateMap<Entities.Address.State, StateDto>();
            CreateMap<Entities.Address.City, CityDto>();
        }
    }
}
