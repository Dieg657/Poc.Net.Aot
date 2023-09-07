using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Npgsql;
using Poc.Aot.Repository;
using Poc.Net.Aot.Repository.Interfaces;

namespace Poc.Net.Aot.Infrastructure.Modules
{
    internal static class InfrastructureModules
    {
        public static IServiceCollection RegisterInfrastructure(this IServiceCollection services, IConfiguration configuration)
            => services.RegisterRepositories(configuration);

        private static IServiceCollection RegisterRepositories(this IServiceCollection services, IConfiguration configuration)
            => services.AddTransient<IEmployeeRepository>(sp => new EmployeeRepository(configuration.GetConnectionString("POSTGRESCONNECTION")));
    }
}
