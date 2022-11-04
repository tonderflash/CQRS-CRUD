using ClientDirectory.Application.Client.Dtos;
using MediatR;

namespace ClientDirectory.Application.Client.Queries
{
    public class GetClientQuery : IRequest<ClientDetailDto>
    {
        public int Id { get; set; }
    }
}
