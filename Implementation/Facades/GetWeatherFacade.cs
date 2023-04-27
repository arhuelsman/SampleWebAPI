using Core.Facade;
using Core.Facade.Interfaces;
using Implementation.Domain;

namespace Implementation.Facades
{
    public class GetWeatherFacade : Facade<WeatherRequest, WeatherReport>
    {
        public GetWeatherFacade(IEnumerable<IAdapter<WeatherRequest, WeatherReport>> adapters) : base(adapters)
        {
        }
    }
}
