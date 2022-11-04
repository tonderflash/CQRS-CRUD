using AutoMapper;
using ClientDirectory.Application.Client.Commands;
using ClientDirectory.Application.Client.Dtos;
using ClientDirectory.Application.GenericHandler;
using ClientDirectory.Application.Interfaces;

namespace ClientDirectory.Application.Client.Handlers.Commands
{
    public class BaseClientCommandHandler
        : BaseCommandHandler<BaseClientCommand, Entities.Client, ClientDetailDto>
    {
        public BaseClientCommandHandler(IClientCrudService ClientService, IMapper mapper) 
            : base(ClientService, mapper)
        {
        }
    }
}
