using System.Collections.Generic;
using log4net;
using Newtonsoft.Json;
using MS.Experiences.Weather.Properties;

namespace MS.Experiences.Weather
{
    public class MeteoBelgiqueDataService : IWeatherForecastService
    {
        private readonly ILog log = log4net.LogManager.GetLogger(typeof(MeteoBelgiqueDataService));

        public IEnumerable<WeatherForecast> GetWeatherForecasts(int startDateIndex)
        {
            log.Info($"Gathering weather from index {startDateIndex}");

            return JsonConvert.DeserializeObject<WeatherForecast[]>(Resources.meteo_belgium);
        }
    }
}
