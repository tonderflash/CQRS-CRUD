using ClientDirectory.Application.Entities.Address;
using ClientDirectory.Application.Interfaces.Address;
using ClientDirectory.Infrastructure.Context;

namespace ClientDirectory.Infrastructure.Services
{
    public class CountryCrudService : BaseCrudService<Country>, ICountryCrudService
    {
        public CountryCrudService(IClientDirectoryDbContext context) : base(context)
        {
        }
    }
}
