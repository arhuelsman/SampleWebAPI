using Core.Facade.Interfaces;
using Core.Service.Controller;
using Implementation.Domain;
using Microsoft.Extensions.Logging;

namespace Implementation
{
    public class WeatherController : ServiceController<WeatherRequest, WeatherReport>
    {
        private IFacade<WeatherRequest, WeatherReport> facade;

        public WeatherController(ILogger logger, IFacade<WeatherRequest, WeatherReport> facade) : base(logger)
        {
            this.facade = facade;
        }

        public override string ServiceName => "WeatherController";

        public async override Task<WeatherReport> OnExecute(WeatherRequest request, string? sourceSystem)
        {
            // Use whatever method of source system determination you would like.
            // This could be from the request directly, or you can use fields from the request to determine as such.
            // Without a request, you might want to use an implementation that returns from one system or all the systems
            var result = await this.facade.Handle(request, sourceSystem);
            this.logger.LogInformation("I got my data!");

            return result;
        }
    }
}