using ClientDirectory.Application.Address.Dtos;
using MediatR;

namespace ClientDirectory.Application.Address.Queries
{
    public class GetCitiesByStateQuery : IRequest<List<CityDto>>
    {
        public int StateId { get; set; }
    }
}
