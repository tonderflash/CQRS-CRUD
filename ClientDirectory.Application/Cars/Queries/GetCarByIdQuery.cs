using ClientDirectory.Application.Cars.Dtos;
using MediatR;

namespace ClientDirectory.Application.Cars.Queries
{
    public class GetCarByIdQuery : IRequest<CarDto>
    {
        public int Id { get; set; }
    }
}
