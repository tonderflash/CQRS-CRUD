using AutoMapper;
using AutoMapper.QueryableExtensions;
using ClientDirectory.Application.Client.Dtos;
using ClientDirectory.Application.Client.Queries;
using ClientDirectory.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDirectory.Application.Client.Handlers.Queries
{
    public class GetClientAddressesQueryHandler : IRequestHandler<GetClientAddressesQuery, List<AddressDto>>
    {
        private readonly IClientAddressCrudService _personAddressCrudService;
        private readonly IClientCrudService _ClientCrudService;
        private readonly IMapper _mapper;

        public GetClientAddressesQueryHandler(IClientAddressCrudService personAddressCrudService, IClientCrudService ClientCrudService, IMapper mapper)
        {
            _personAddressCrudService = personAddressCrudService;
            _ClientCrudService = ClientCrudService;
            _mapper = mapper;
        }
        public async Task<List<AddressDto>> Handle(GetClientAddressesQuery request, CancellationToken cancellationToken)
        {
            var clientId = await _ClientCrudService.Query()
                .Where(x => x.Id == request.ClientId)
                .Select(x => x.Id)
                .FirstAsync(cancellationToken: cancellationToken);

            if (clientId == 0) throw new Exception($"Client with id {request.ClientId} was not foud");

            var query = _personAddressCrudService.Query()
                .Where(x => x.ClientId == clientId)
                .Skip(request.Skip)
                .Take(request.Take);

            var queryMapped = query.ProjectTo<AddressDto>(_mapper.ConfigurationProvider);

            return await queryMapped.ToListAsync(cancellationToken: cancellationToken);
        }
    }
}
