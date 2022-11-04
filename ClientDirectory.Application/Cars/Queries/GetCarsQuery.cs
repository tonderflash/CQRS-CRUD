using ClientDirectory.Application.Cars.Dtos;
using MediatR;

namespace ClientDirectory.Application.Cars.Queries
{
    public class GetCarsQuery : IRequest<List<CarDto>>
    {
    }
}
