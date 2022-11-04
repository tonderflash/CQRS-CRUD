using AutoMapper;
using ClientDirectory.Application.Cars.Dtos;
using ClientDirectory.Application.Cars.Queries;
using ClientDirectory.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ClientDirectory.Application.Cars.Handlers.Queries
{
    public class GetCarByIdQueryHandler : IRequestHandler<GetCarByIdQuery, CarDto>
    {
        private readonly ICarCrudService _carService;
        private readonly IMapper _mapper;

        public GetCarByIdQueryHandler(ICarCrudService carService, IMapper mapper)
        {
            _carService = carService;
            _mapper = mapper;
        }

        public async Task<CarDto> Handle(GetCarByIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await _carService.Query()
                .Where(x => x.Id == request.Id)
                .FirstAsync();

            if (entity == null) throw new Exception($"Car with id {request.Id} was not found");

            var dto = _mapper.Map<CarDto>(entity);

            return dto;
        }
    }
}
