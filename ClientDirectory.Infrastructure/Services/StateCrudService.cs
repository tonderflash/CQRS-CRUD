using ClientDirectory.Application.Entities.Address;
using ClientDirectory.Application.Interfaces.Address;
using ClientDirectory.Infrastructure.Context;

namespace ClientDirectory.Infrastructure.Services
{
    public class StateCrudService : BaseCrudService<State>, IStateCrudService
    {
        public StateCrudService(IClientDirectoryDbContext context) : base(context)
        {
        }
    }
}
