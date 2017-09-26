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
        private readonly IWeatherDataServiceFactory _weatherDataServiceFactory;

        public WeatherForecastController(IWeatherForecastService wheatherForecastService, IWeatherDataServiceFactory weatherDataServiceFactory)
        {
            this.wheatherForecastService = wheatherForecastService;
            this._weatherDataServiceFactory = weatherDataServiceFactory;
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
            log.Info($"Requesting weather info for {country}");
            IWeatherForecastService weatherForecastService = this._weatherDataServiceFactory.Get(country);
            return weatherForecastService.GetWeatherForecasts(startIndex);
        }
    }
}