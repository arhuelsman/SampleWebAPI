using Core.Facade.Interfaces;
using Implementation.Domain;
using Implementation.Facades;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddImplementation(this IServiceCollection services)
        {
            services.AddTransient<IFacade<WeatherRequest, WeatherReport>, GetWeatherFacade>();
            services.AddTransient<IFacade<ZipCodesResponse>, ZipCodesFacade>();
            services.AddTransient<WeatherController>();
            services.AddTransient<ZipCodesController>();

            return services;
        }
    }
}
