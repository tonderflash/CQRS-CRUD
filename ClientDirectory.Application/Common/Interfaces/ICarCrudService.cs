using ClientDirectory.Application.Common.Entities.Car;
using ClientDirectory.Application.Interfaces;

namespace ClientDirectory.Application.Common.Interfaces
{
    public interface ICarCrudService : IBaseCrudService<Car>
    {
    }
}
