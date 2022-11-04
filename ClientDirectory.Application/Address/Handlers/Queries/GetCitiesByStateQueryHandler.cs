using AutoMapper;
using ClientDirectory.Application.Address.Dtos;
using ClientDirectory.Application.Address.Queries;
using ClientDirectory.Application.Interfaces.Address;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ClientDirectory.Application.Address.Handlers.Queries
{
    public class GetCitiesByStateQueryHandler : IRequestHandler<GetCitiesByStateQuery, List<CityDto>>
    {
        private readonly ICityCrudService _cityCrudService;
        private readonly IMapper _mapper;

        public GetCitiesByStateQueryHandler(ICityCrudService cityCrudService, IMapper mapper)
        {
            _cityCrudService = cityCrudService;
            _mapper = mapper;
        }

        public async Task<List<CityDto>> Handle(GetCitiesByStateQuery request, CancellationToken cancellationToken)
        {
            var cities = await _cityCrudService.Query()
                .Where(x => x.StateId == request.StateId)
                .ToListAsync();

            var citiesDto = _mapper.Map<List<CityDto>>(cities);

            return citiesDto;
        }
    }
}
