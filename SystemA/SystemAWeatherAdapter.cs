using Core.Facade.Interfaces;
using Implementation.Domain;

namespace SystemA
{
    public class SystemAWeatherAdapter : IAdapter<WeatherRequest, WeatherReport>
    {
        public Task<WeatherReport> Handle(WeatherRequest request)
        {
            // Perform data retrieval in whatever way, and map the result to the response
            return Task.FromResult(new WeatherReport
            {
                Temperature = 20,
                Humidity = 10,
                WindStrength = 5,
                WindDirection = "NNE"
            });
        }

        public bool HandlesSourceSystem(string? sourceSystem)
        {
            return sourceSystem == "SystemA";
        }
    }
}