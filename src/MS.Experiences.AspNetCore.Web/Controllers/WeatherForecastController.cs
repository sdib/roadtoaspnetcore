using Microsoft.AspNetCore.Mvc;
using MS.Experiences.Weather;
using System.Collections.Generic;

namespace MS.Experiences.AspNetCore.Web
{
    public class WeatherForecastController : Controller
    {
        private IWeatherForecastService wheatherForecastService;
        private IWeatherDataServiceFactory _weatherDataServiceFactory;

        public WeatherForecastController(IWeatherForecastService wheatherForecastService, IWeatherDataServiceFactory weatherDataServiceFactory)
        {
            this.wheatherForecastService = wheatherForecastService;
            this._weatherDataServiceFactory = weatherDataServiceFactory;
        }

        public IEnumerable<WeatherForecast> Get(int startIndex)
        {
            return null;
        }
        
        public IEnumerable<WeatherForecast> GetByCountry(int startIndex, string country)
        {
            return null;
        }
    }
}
