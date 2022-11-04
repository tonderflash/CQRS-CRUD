using ClientDirectory.Application.Entities;
using ClientDirectory.Application.Entities.Address;
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

        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientAddress> ClientAddresses { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<State> States { get; set; }
    }
}
