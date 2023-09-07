using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Poc.Net.Aot.Infrastructure.Modules;

namespace Poc.Net.Aot.Infrastructure
{
    public static class IoC
    {
        public static IServiceCollection RegisterContainer(this IServiceCollection services, IConfiguration configuration)
            => services.RegisterInfrastructure(configuration)
                       .RegisterAplication();

    }
}
