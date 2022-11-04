using AutoMapper;
using ClientDirectory.Application.Client.Dtos;
using ClientDirectory.Application.Client.Queries;
using ClientDirectory.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ClientDirectory.Application.Client.Handlers.Queries
{
    public class GetClientQueryHandler : IRequestHandler<GetClientQuery ,ClientDetailDto>
    {
        private readonly IClientCrudService _ClientCrudService;
        private readonly IMapper _mapper;

        public GetClientQueryHandler(IClientCrudService ClientCrudService, IMapper mapper)
        {
            _ClientCrudService = ClientCrudService;
            _mapper = mapper;
        }

        public async Task<ClientDetailDto> Handle(GetClientQuery request, CancellationToken cancellationToken)
        {
            var entity = await _ClientCrudService.Query()
                .Where(x => x.Id == request.Id)
                .FirstAsync();

            if (entity == null) throw new Exception($"Client with id {request.Id} was not found");

            var dto = _mapper.Map<ClientDetailDto>(entity);
            
            return dto;
        }
    }
}
