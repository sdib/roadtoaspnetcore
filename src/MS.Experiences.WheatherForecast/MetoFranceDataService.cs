using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using log4net;

namespace MS.Experiences.WheatherForecast
{
    public class MeteoFranceDataService : IWheatherForecastService
    {
        private readonly ILog log = log4net.LogManager.GetLogger(typeof(MeteoFranceDataService));

        public IEnumerable<WeatherForecast> GetWeatherForecasts(int startDateIndex)
        {
            log.Info($"Gathering weather from index {startDateIndex}");

            int temperatureMinimum = Int32.Parse(ConfigurationManager.AppSettings["TemperatureMinimum"]);
            int temperatureMaximum = Int32.Parse(ConfigurationManager.AppSettings["TemperatureMaximum"]);

            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                DateFormatted = DateTime.Now.AddDays(index + startDateIndex).ToString("d"),
                TemperatureC = rng.Next(temperatureMinimum, temperatureMaximum),
                Summary = Summaries[rng.Next(Summaries.Length)]
            });
        }

        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
    }
}
