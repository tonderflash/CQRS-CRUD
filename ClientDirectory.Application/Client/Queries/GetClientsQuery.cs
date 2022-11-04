using ClientDirectory.Application.Client.Dtos;
using MediatR;

namespace ClientDirectory.Application.Client.Queries
{
    public class GetClientsQuery : IRequest<List<ClientDto>>
    {
        public int Skip { get; set; }
        public int Take { get; set; }
    }
}
