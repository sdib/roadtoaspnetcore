using System.Collections.Generic;
using System.Web.Http;
using MS.Exeriences.WheatherForecast;

namespace MS.Experiences.Web.Controllers
{
    public class WeatherForecastController : ApiController
    {
        [HttpGet]
        [Route("api/weather/{startIndex}")]
        public IEnumerable<WeatherForecast> Get(int startIndex)
        {
            var meteoFranceDataService = new MeteoFranceDataService();

            return meteoFranceDataService.GetWeatherForecasts(startIndex);
        }

    }
}