using ClientDirectory.Application.Interfaces;
using ClientDirectory.Application.Interfaces.Address;
using ClientDirectory.Infrastructure.Context;
using ClientDirectory.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ClientDirectory.Infrastructure
{
    public static class IoC
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IClientCrudService, ClientCrudService>();
            services.AddTransient<IClientAddressCrudService, ClientAddressCrudService>();
            services.AddTransient<ICityCrudService, CityCrudService>();
            services.AddTransient<ICountryCrudService, CountryCrudService>();
            services.AddTransient<IStateCrudService, StateCrudService>();
            services.AddTransient<IClientDirectoryDbContext, ClientDirectoryDbContext>();

            return services;
        }

    }
}