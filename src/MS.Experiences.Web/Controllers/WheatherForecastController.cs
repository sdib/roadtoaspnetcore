using System.Collections.Generic;
using System.Web.Http;
using MS.Exeriences.WheatherForecast;
using log4net;

namespace MS.Experiences.Web.Controllers
{
    public class WeatherForecastController : ApiController
    {
        private ILog log = log4net.LogManager.GetLogger(typeof(WeatherForecastController));

        [HttpGet]
        [Route("api/weather/{startIndex}")]
        public IEnumerable<WeatherForecast> Get(int startIndex)
        {
            log.Info("Requesting wheather info");

            var meteoFranceDataService = new MeteoFranceDataService();

            return meteoFranceDataService.GetWeatherForecasts(startIndex);
        }

    }
}