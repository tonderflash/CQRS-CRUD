using ClientDirectory.Application.Client.Dtos;
using ClientDirectory.Application.Entities;
using MediatR;

namespace ClientDirectory.Application.Client.Queries
{
    public class GetClientAddressQuery : IRequest<ClientAddress>
    {
        public int AddressId { get; set; }
    }
}
