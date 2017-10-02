using System.Collections.Generic;
using System.Web.Http;
using MS.Experiences.Weather;

namespace MS.Experiences.Web.Controllers
{
    public class WeatherForecastController : ApiController
    {
        private readonly IWeatherForecastService _wheatherForecastService;

        public WeatherForecastController(IWeatherForecastService wheatherForecastService)
        {
            this._wheatherForecastService = wheatherForecastService;
        }

        [HttpGet]
        [Route("api/weather/{startIndex}")]
        public IEnumerable<WeatherForecast> Get(int startIndex)
        {
            return this._wheatherForecastService.GetWeatherForecasts(startIndex);
        }
    }
}