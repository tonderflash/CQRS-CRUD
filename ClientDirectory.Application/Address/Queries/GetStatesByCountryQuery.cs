using ClientDirectory.Application.Address.Dtos;
using MediatR;

namespace ClientDirectory.Application.Address.Queries
{
    public class GetStatesByCountryQuery : IRequest<List<StateDto>>
    {
        public int CountryId { get; set; }
    }
}
