using Core.Facade.Interfaces;
using Implementation.Domain;
using Microsoft.Extensions.DependencyInjection;

namespace SystemB
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddSystemB(this IServiceCollection services)
        {
            services.AddScoped<IAdapter<WeatherRequest, WeatherReport>, SystemBWeatherAdapter>();
            services.AddScoped<IAdapter<ZipCodesResponse>, SystemBZipCodesAdapter>();

            return services;
        }
    }
}
