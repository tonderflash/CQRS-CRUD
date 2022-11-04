using ClientDirectory.Application.Entities;
using ClientDirectory.Application.Interfaces;
using ClientDirectory.Infrastructure.Context;

namespace ClientDirectory.Infrastructure.Services
{
    public class ClientAddressCrudService : BaseCrudService<ClientAddress>, IClientAddressCrudService
    {
        public ClientAddressCrudService(IClientDirectoryDbContext context) : base(context)
        {
        }
    }
}
