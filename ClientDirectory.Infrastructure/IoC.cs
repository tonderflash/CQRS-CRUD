using ClientDirectory.Application.Common.Interfaces;
using ClientDirectory.Infrastructure.Context;
using ClientDirectory.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ClientDirectory.Infrastructure
{
    public static class IoC
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<ICarCrudService, CarsCrudService>();
            services.AddTransient<IClientDirectoryDbContext, ClientDirectoryDbContext>();

            return services;
        }

    }
}