using System.Collections.Generic;
using System.Web.Http;
using MS.Exeriences.WheatherForecast;
using log4net;

namespace MS.Experiences.Web.Controllers
{
    public class WeatherForecastController : ApiController
    {
        private readonly ILog log = log4net.LogManager.GetLogger(typeof(WeatherForecastController));
        private readonly IWheatherForecastService wheatherForecastService;
        private readonly IWheatherFactory wheatherFactory;

        public WeatherForecastController(IWheatherForecastService wheatherForecastService, IWheatherFactory wheatherFactory)
        {
            this.wheatherForecastService = wheatherForecastService;
            this.wheatherFactory = wheatherFactory;
        }

        [HttpGet]
        [Route("api/weather/{startIndex}")]
        public IEnumerable<WeatherForecast> Get(int startIndex)
        {
            log.Info("Requesting wheather info");
            return this.wheatherForecastService.GetWeatherForecasts(startIndex);
        }

        [HttpGet]
        [Route("api/weather/{startIndex}/{country}")]
        public IEnumerable<WeatherForecast> GetByCountry(int startIndex, string country)
        {
            log.Info($"Requesting wheather info from country {country}");
            return this.wheatherFactory.GetDataService(country).GetWeatherForecasts(startIndex);
        }
    }
}