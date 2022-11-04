using AutoMapper;
using ClientDirectory.Application.Address.Dtos;
using ClientDirectory.Application.Address.Queries;
using ClientDirectory.Application.Interfaces.Address;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ClientDirectory.Application.Address.Handlers.Queries
{
    public class GetStatesByCountryQueryHandler : IRequestHandler<GetStatesByCountryQuery, List<StateDto>>
    {
        private readonly IStateCrudService _stateCrudService;
        private readonly IMapper _mapper;

        public GetStatesByCountryQueryHandler(IStateCrudService stateCrudService, IMapper mapper)
        {
            _stateCrudService = stateCrudService;
            _mapper = mapper;
        }

        public async Task<List<StateDto>> Handle(GetStatesByCountryQuery request, CancellationToken cancellationToken)
        {
            var states = await _stateCrudService.Query()
                .Where(x => x.CountryId == request.CountryId)
                .ToListAsync();

            var statesDto = _mapper.Map<List<StateDto>>(states);

            return statesDto;
        }
    }
}
