using ClientDirectory.Application.Entities;
using ClientDirectory.Application.Entities.Address;
using ClientDirectory.Application.Interfaces;
using ClientDirectory.Application.Interfaces.Address;
using ClientDirectory.Infrastructure.Context;

namespace ClientDirectory.Infrastructure.Services
{
    public class CityCrudService : BaseCrudService<City>, ICityCrudService
    {
        public CityCrudService(IClientDirectoryDbContext context) : base(context)
        {
        }
    }
}
