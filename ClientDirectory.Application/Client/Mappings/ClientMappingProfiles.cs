using AutoMapper;
using ClientDirectory.Application.Client.Commands;
using ClientDirectory.Application.Client.Dtos;
using ClientDirectory.Application.Entities;

namespace ClientDirectory.Application.Client.Mappings
{
    public class ClientMappingProfiles : Profile
    {
        public ClientMappingProfiles()
        {
            CreateMap<BaseClientCommand,Entities.Client>();
            CreateMap<BaseClientAddressCommand, ClientAddress>();
            CreateMap<Entities.Client, ClientDetailDto>()
                .ForMember(destination => destination.BirthDate, op => op.MapFrom(source => source.BirthDate.Date.ToString("dd/MM/yyyy")));
            CreateMap<Entities.Client, ClientDto>();
            CreateMap<ClientAddress, AddressDto>()
                .ForMember(destination => destination.Country, op => op.MapFrom(source => source.Country.Name))
                .ForMember(destination => destination.City, op => op.MapFrom(source => source.City.Name))
                .ForMember(destination => destination.State, op => op.MapFrom(source => source.State.Name))
                .ForMember(destination => destination.AddressTypeLabel, op => op.MapFrom(source => source.AddressType.ToString()));
        }
    }
}
