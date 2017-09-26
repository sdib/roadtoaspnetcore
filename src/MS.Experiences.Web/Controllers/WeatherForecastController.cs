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
        private readonly IWeatherFactory _weatherFactory;

        public WeatherForecastController(IWeatherForecastService wheatherForecastService, IWeatherFactory weatherFactory)
        {
            this.wheatherForecastService = wheatherForecastService;
            this._weatherFactory = weatherFactory;
        }

        [HttpGet]
        [Route("api/weather/{startIndex}")]
        public IEnumerable<WeatherForecast> Get(int startIndex)
        {
            log.Info("Requesting weather info");
            return this.wheatherForecastService.GetWeatherForecasts(startIndex);
        }

        [HttpGet]
        [Route("api/weather/{startIndex}/{country}")]
        public IEnumerable<WeatherForecast> GetByCountry(int startIndex, string country)
        {
            log.Info($"Requesting weather info from country {country}");
            return this._weatherFactory.GetDataService(country).GetWeatherForecasts(startIndex);
        }
    }
}