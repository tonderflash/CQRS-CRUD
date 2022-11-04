using ClientDirectory.Application.Cars.Dtos;
using ClientDirectory.Application.GenericHandler;

namespace ClientDirectory.Application.Cars.Commands
{
    public class BaseCarCommand : BaseCommand<CarDto>
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }
}
