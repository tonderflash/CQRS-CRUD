using ClientDirectory.Application.Client.Dtos;
using MediatR;

namespace ClientDirectory.Application.Client.Queries
{
    public class GetClientAddressesQuery : IRequest<List<AddressDto>>
    {
        public int ClientId { get; set; }
        public int Skip { get; set; }
        public int Take { get; set; }
    }
}
