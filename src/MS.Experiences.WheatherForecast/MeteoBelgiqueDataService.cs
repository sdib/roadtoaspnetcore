using log4net;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace MS.Exeriences.WheatherForecast
{
    public class MeteoBelgiqueDataService : IWheatherForecastService
    {
        //private readonly ILog log = log4net.LogManager.GetLogger(typeof(MeteoFranceDataService));

        public IEnumerable<WeatherForecast> GetWeatherForecasts(int startDateIndex)
        {
           /* log.Info($"Gathering weather from index {startDateIndex}");

            int temperatureMinimum = Int32.Parse(ConfigurationManager.AppSettings["TemperatureMinimum"]);
            int temperatureMaximum = Int32.Parse(ConfigurationManager.AppSettings["TemperatureMaximum"]);

            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                DateFormatted = DateTime.Now.AddDays(index + startDateIndex).ToString("d"),
                TemperatureC = rng.Next(temperatureMinimum, temperatureMaximum),
                Summary = Summaries[rng.Next(Summaries.Length)]
            });*/
            return null;
        }

        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
    }
}
