using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace MS.Experiences.Weather
{
    public class MeteoFranceDataService : IWeatherForecastService
    {
        private readonly WeatherOptions _options;

        public MeteoFranceDataService()
        {
            _options = new WeatherOptions
            {
                TemperatureMax = Int32.Parse(ConfigurationManager.AppSettings["TemperatureMaximum"]),
                TemprateurMin = Int32.Parse(ConfigurationManager.AppSettings["TemperatureMinimum"])
            };
        }

        public IEnumerable<WeatherForecast> GetWeatherForecasts(int startDateIndex)
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                DateFormatted = DateTime.Now.AddDays(index + startDateIndex).ToShortDateString(),
                TemperatureC = rng.Next(_options.TemprateurMin, _options.TemperatureMax),
                Summary = Summaries[rng.Next(Summaries.Length)]
            });
        }

        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
    }
}
