using Microsoft.Extensions.DependencyInjection;
using Poc.Net.Aot.Application.Interfaces.Services;
using Poc.Net.Aot.Application.Services;

namespace Poc.Net.Aot.Infrastructure.Modules
{
    internal static class ApplicationModules
    {
        public static IServiceCollection RegisterAplication(this IServiceCollection services)
            => services.RegisterServices();

        private static IServiceCollection RegisterServices(this IServiceCollection services)
            => services.AddScoped<IEmployeeService, EmployeeService>();
    }
}
