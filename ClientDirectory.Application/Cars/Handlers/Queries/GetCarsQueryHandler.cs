using AutoMapper;
using ClientDirectory.Application.Cars.Dtos;
using ClientDirectory.Application.Cars.Queries;
using ClientDirectory.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ClientDirectory.Application.Cars.Handlers.Queries
{
    public class GetCarsQueryHandler : IRequestHandler<GetCarsQuery, List<CarDto>>
    {
        private readonly ICarCrudService _carService;
        private readonly IMapper _mapper;

        public GetCarsQueryHandler(ICarCrudService carService, IMapper mapper)
        {
            _carService = carService;
            _mapper = mapper;
        }

        public async Task<List<CarDto>> Handle(GetCarsQuery request, CancellationToken cancellationToken)
        {
            var cars = await _carService.Query().ToListAsync();

            var carDto = _mapper.Map<List<CarDto>>(cars);

            return carDto;
        }
    }
}
