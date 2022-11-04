using AutoMapper;
using ClientDirectory.Application.Cars.Commands;
using ClientDirectory.Application.Cars.Dtos;
using ClientDirectory.Application.Common.Entities.Car;

namespace ClientDirectory.Application.Cars.Mappings
{
    public class CarMappingProfile : Profile
    {
        public CarMappingProfile()
        {
            CreateMap<BaseCarCommand, Car>();
            CreateMap<Car, CarDto>();
        }
    }
}
