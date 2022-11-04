using ClientDirectory.Application.Common.Entities.Car;
using ClientDirectory.Application.Common.Interfaces;
using ClientDirectory.Infrastructure.Context;

namespace ClientDirectory.Infrastructure.Services
{
    public class CarsCrudService : BaseCrudService<Car>, ICarCrudService
    {
        public CarsCrudService(IClientDirectoryDbContext context) : base(context)
        {

        }
    }
}
