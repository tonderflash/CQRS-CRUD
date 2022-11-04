using ClientDirectory.Application.Address.Dtos;
using ClientDirectory.Application.Entities.Address;
using MediatR;

namespace ClientDirectory.Application.Address.Queries
{
    public class GetCountriesQuery : IRequest<List<CountryDto>>
    {
    }
}
