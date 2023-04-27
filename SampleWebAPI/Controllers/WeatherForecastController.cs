using Implementation;
using Implementation.Domain;
using Microsoft.AspNetCore.Mvc;

namespace SampleWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly WeatherController weatherController;
        private readonly ZipCodesController zipCodesController;

        public WeatherForecastController(WeatherController weatherController, ZipCodesController zipCodesController)
        {
            this.weatherController = weatherController;
            this.zipCodesController = zipCodesController;
        }

        [HttpGet("GetWeatherForecast/{zipCode}")]
        public async Task<IActionResult> Get(string zipCode)
        {
            if (!int.TryParse(zipCode, out var code) || zipCode.Length != 5)
            {
                return BadRequest("Please supply a valid 5 digit zip code");
            }

            var request = new WeatherRequest()
            {
                ZipCode = code
            };
            return Ok(await this.weatherController.OnExecute(request, "SystemA"));
        }

        [HttpGet("v2/GetWeatherForecast/{zipCode}")]
        public async Task<IActionResult> GetV2(string zipCode)
        {
            if (!int.TryParse(zipCode, out var code) || zipCode.Length != 5)
            {
                return BadRequest("Please supply a valid 5 digit zip code");
            }

            var request = new WeatherRequest()
            {
                ZipCode = code
            };
            return Ok(await this.weatherController.OnExecute(request, "SystemB"));
        }

        [HttpGet("GetZipCodes")]
        public async Task<IActionResult> GetZipCodes()
        {
            return Ok(await this.zipCodesController.OnExecute("SystemA"));
        }

        [HttpGet("v2/GetZipCodes")]
        public async Task<IActionResult> GetZipCodesV2()
        {
            return Ok(await this.zipCodesController.OnExecute("SystemB"));
        }
    }
}