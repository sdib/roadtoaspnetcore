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

        public WeatherForecastController(IWheatherForecastService wheatherForecastService)
        {
            this.wheatherForecastService = wheatherForecastService;
        }

        [HttpGet]
        [Route("api/weather/{startIndex}")]
        public IEnumerable<WeatherForecast> Get(int startIndex)
        {
            log.Info("Requesting wheather info");

            return this.wheatherForecastService.GetWeatherForecasts(startIndex);
        }
    }
}