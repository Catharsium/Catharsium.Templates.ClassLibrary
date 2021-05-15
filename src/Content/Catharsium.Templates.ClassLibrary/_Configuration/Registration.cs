using Catharsium.Util.Configuration.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Catharsium.Templates.ClassLibrary._Configuration
{
    public static class Registration
    {
        public static IServiceCollection AddCatharsiumProjectClassName(this IServiceCollection services, IConfiguration config)
        {
            var configuration = config.Load<Settings>();
            services.AddSingleton<Settings, Settings>(provider => configuration);

            return services;
        }
    }
}