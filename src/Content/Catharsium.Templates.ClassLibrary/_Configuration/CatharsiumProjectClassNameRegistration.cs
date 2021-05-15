using Catharsium.Util.Configuration.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Catharsium.Templates.ClassLibrary._Configuration
{
    public static class CatharsiumProjectClassNameRegistration
    {
        public static IServiceCollection AddUnitTests(this IServiceCollection services, IConfiguration config)
        {
            var configuration = config.Load<CatharsiumProjectClassNameSettings>();
            services.AddSingleton<CatharsiumProjectClassNameSettings, CatharsiumProjectClassNameSettings>(provider => configuration);

            return services;
        }
    }
}