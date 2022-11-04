using AutoMapper;
using ClientDirectory.Application.Address.Dtos;
using ClientDirectory.Application.Address.Queries;
using ClientDirectory.Application.Interfaces.Address;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ClientDirectory.Application.Address.Handlers.Queries
{
    public class GetCountriesQueryHandler : IRequestHandler<GetCountriesQuery, List<CountryDto>>
    {
        private readonly ICountryCrudService _countryCrudService;
        private readonly IMapper _mapper;

        public GetCountriesQueryHandler(ICountryCrudService countryCrudService, IMapper mapper)
        {
            _countryCrudService = countryCrudService;
            _mapper = mapper;
        }
        public async Task<List<CountryDto>> Handle(GetCountriesQuery request, CancellationToken cancellationToken)
        {
            var countries = await _countryCrudService.Query().ToListAsync();

            var countriesDto = _mapper.Map<List<CountryDto>>(countries);

            return countriesDto;
        }
    }
}
