using Core.Facade.Interfaces;
using Core.Service.Controller;
using Implementation.Domain;
using Microsoft.Extensions.Logging;

namespace Implementation
{
    public class ZipCodesController : ServiceController<ZipCodesResponse>
    {
        private IFacade<ZipCodesResponse> facade;

        public ZipCodesController(ILogger logger, IFacade<ZipCodesResponse> facade) : base(logger)
        {
            this.facade = facade;
        }

        public override string ServiceName => "WeatherController";

        public async override Task<ZipCodesResponse> OnExecute(string? sourceSystem)
        {
            // Use whatever method of source system determination you would like.
            // This could be from the request directly, or you can use fields from the request to determine as such.
            // Without a request, you might want to use an implementation that returns from one system or all the systems
            var result = await this.facade.Handle(sourceSystem);
            this.logger.LogInformation("I got my data!");

            return result;
        }
    }
}