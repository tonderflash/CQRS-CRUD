using AutoMapper;
using AutoMapper.QueryableExtensions;
using ClientDirectory.Application.Client.Dtos;
using ClientDirectory.Application.Client.Queries;
using ClientDirectory.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ClientDirectory.Application.Client.Handlers.Queries
{
    public class GetClientsQueryHandler : IRequestHandler<GetClientsQuery, List<ClientDto>>
    {
        private readonly IClientCrudService _clientCrudService;
        private readonly IMapper _mapper;

        public GetClientsQueryHandler(IClientCrudService clientCrudService, IMapper mapper)
        {
            _clientCrudService = clientCrudService;
            _mapper = mapper;
        }
        public async Task<List<ClientDto>> Handle(GetClientsQuery request, CancellationToken cancellationToken)
        {
            var query = _clientCrudService.Query().Take(request.Take).Skip(request.Skip);

            var queryMapped = query.ProjectTo<ClientDto>(_mapper.ConfigurationProvider);

            return await queryMapped.ToListAsync(cancellationToken: cancellationToken);
        }
    }
}
