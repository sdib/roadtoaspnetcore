using System.Collections.Generic;
using MS.Experiences.Weather;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MS.Experiences.Web.Controllers
{
    public class WeatherForecastController : Controller
    {
        private readonly IWeatherDataServiceFactory _weatherDataServiceFactory;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("api/weather/{startIndex}")]
        public IEnumerable<WeatherForecast> Get([FromServices] IWeatherForecastService wheatherForecastService, int startIndex)
        {
            _logger.LogInformation("Requesting weather info");
            return wheatherForecastService.GetWeatherForecasts(startIndex);
        }

        [HttpGet]
        [Route("api/weather/{startIndex}/{country}")]
        public IEnumerable<WeatherForecast> GetByCountry([FromServices] IWeatherDataServiceFactory weatherDataServiceFactory, int startIndex, string country)
        {
            _logger.LogInformation($"Requesting weather info for {country}");
            IWeatherForecastService weatherForecastService = weatherDataServiceFactory.Get(country);
            return weatherForecastService.GetWeatherForecasts(startIndex);
        }
    }
}