using AutoMapper;
using ClientDirectory.Application.Client.Commands;
using ClientDirectory.Application.Client.Dtos;
using ClientDirectory.Application.Entities;
using ClientDirectory.Application.GenericHandler;
using ClientDirectory.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDirectory.Application.Client.Handlers.Commands
{
    public class BaseClientAddressCommandHandler : BaseCommandHandler<BaseClientAddressCommand, ClientAddress, AddressDto>
    {
        public BaseClientAddressCommandHandler(IClientAddressCrudService clientAddress, IMapper mapper) : base(clientAddress, mapper)
        {
        }
    }
}
