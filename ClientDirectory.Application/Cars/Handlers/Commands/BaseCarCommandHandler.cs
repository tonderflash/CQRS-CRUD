using AutoMapper;
using ClientDirectory.Application.Cars.Commands;
using ClientDirectory.Application.Cars.Dtos;
using ClientDirectory.Application.Common.Entities.Car;
using ClientDirectory.Application.Common.Interfaces;
using ClientDirectory.Application.GenericHandler;

namespace ClientDirectory.Application.Cars.Handlers.Commands
{
    public class BaseCarCommandHandler : BaseCommandHandler<BaseCarCommand, Car, CarDto>
    {
        public BaseCarCommandHandler(ICarCrudService carCrudService, IMapper mapper) : base(carCrudService, mapper)
        {

        }
    }
}
