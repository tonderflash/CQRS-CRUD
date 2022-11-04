using AutoMapper;
using ClientDirectory.Application.Address.Commands;
using ClientDirectory.Application.Address.Dtos;
using ClientDirectory.Application.Entities.Address;
using ClientDirectory.Application.GenericHandler;
using ClientDirectory.Application.Interfaces.Address;

namespace ClientDirectory.Application.Address.Handlers.Commands
{
    public class BaseStateCommandHandler : BaseCommandHandler<BaseStateCommand, State, StateDto>
    {
        public BaseStateCommandHandler(IStateCrudService stateCrudService, IMapper mapper) : base(stateCrudService, mapper)
        {
        }
    }
}
