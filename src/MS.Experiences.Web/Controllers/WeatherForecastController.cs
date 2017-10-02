using System.Collections.Generic;
using System.Web.Http;
using log4net;
using MS.Experiences.Weather;

namespace MS.Experiences.Web.Controllers
{
    public class WeatherForecastController : ApiController
    {
        private readonly ILog log = log4net.LogManager.GetLogger(typeof(WeatherForecastController));
        private readonly IWeatherForecastService wheatherForecastService;

        public WeatherForecastController(IWeatherForecastService wheatherForecastService)
        {
            this.wheatherForecastService = wheatherForecastService;
        }

        [HttpGet]
        [Route("api/weather/{startIndex}")]
        public IEnumerable<WeatherForecast> Get(int startIndex)
        {
            log.Info("Requesting weather info");
            return this.wheatherForecastService.GetWeatherForecasts(startIndex);
        }
    }
}