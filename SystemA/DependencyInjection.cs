using Core.Facade.Interfaces;
using Implementation.Domain;
using Microsoft.Extensions.DependencyInjection;

namespace SystemA
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddSystemA(this IServiceCollection services)
        {
            services.AddScoped<IAdapter<WeatherRequest, WeatherReport>, SystemAWeatherAdapter>();
            services.AddScoped<IAdapter<ZipCodesResponse>, SystemAZipCodesAdapter>();

            return services;
        }
    }
}
