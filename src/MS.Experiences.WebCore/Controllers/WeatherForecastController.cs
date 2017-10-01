using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MS.Experiences.Weather;

namespace MS.Experiences.WebCore.Controllers
{
    public class WeatherForecastController : Controller
    {
        private readonly IWeatherForecastService wheatherForecastService;

        public WeatherForecastController(IWeatherForecastService wheatherForecastService)
        {
            this.wheatherForecastService = wheatherForecastService;
        }

        [HttpGet]
        [Route("api/weather/{startIndex}")]
        public IEnumerable<WeatherForecast> Get(int startIndex)
        {
            //log.Info("Requesting weather info");
            return this.wheatherForecastService.GetWeatherForecasts(startIndex);
        }


    }
}