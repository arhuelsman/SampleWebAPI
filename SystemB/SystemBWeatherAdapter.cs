using Core.Facade.Interfaces;
using Implementation.Domain;

namespace SystemB
{
    public class SystemBWeatherAdapter : IAdapter<WeatherRequest, WeatherReport>
    {
        public Task<WeatherReport> Handle(WeatherRequest request)
        {
            // Perform data retrieval in whatever way, and map the result to the response
            return Task.FromResult(new WeatherReport
            {
                Temperature = 40,
                Humidity = 20,
                WindStrength = 10,
                WindDirection = "S"
            });
        }

        public bool HandlesSourceSystem(string? sourceSystem)
        {
            return sourceSystem == "SystemB";
        }
    }
}