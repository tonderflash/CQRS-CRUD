using ClientDirectory.Domain.Common.BaseEntity;

namespace ClientDirectory.Application.Common.Entities.Car
{
    public class Car : BaseEntity
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }
}
