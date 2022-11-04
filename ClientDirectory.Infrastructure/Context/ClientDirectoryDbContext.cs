using ClientDirectory.Application.Common.Entities.Car;
using Microsoft.EntityFrameworkCore;

namespace ClientDirectory.Infrastructure.Context
{
    public interface IClientDirectoryDbContext : IDbContext
    {

    }
    public class ClientDirectoryDbContext : BaseDbContext, IClientDirectoryDbContext
    {
        public ClientDirectoryDbContext(DbContextOptions<ClientDirectoryDbContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
    }
}
