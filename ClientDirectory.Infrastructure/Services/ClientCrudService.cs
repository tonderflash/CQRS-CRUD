using ClientDirectory.Application.Entities;
using ClientDirectory.Application.Interfaces;
using ClientDirectory.Infrastructure.Context;

namespace ClientDirectory.Infrastructure.Services
{
    public class ClientCrudService : BaseCrudService<Client>, IClientCrudService
    {
        public ClientCrudService(IClientDirectoryDbContext context) : base(context)
        {
        }
    }
}
