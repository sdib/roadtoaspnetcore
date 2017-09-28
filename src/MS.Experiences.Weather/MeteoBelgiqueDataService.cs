using System.Collections.Generic;
using Newtonsoft.Json;
using MS.Experiences.Weather.Properties;

namespace MS.Experiences.Weather
{
    public class MeteoBelgiqueDataService : IWeatherForecastService
    {
        public IEnumerable<WeatherForecast> GetWeatherForecasts(int startDateIndex)
        {
            return JsonConvert.DeserializeObject<WeatherForecast[]>(Resources.meteo_belgium);
        }
    }
}
