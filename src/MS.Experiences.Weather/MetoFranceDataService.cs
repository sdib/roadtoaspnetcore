using System;
using System.Collections.Generic;
using System.Linq;
using log4net;
using MS.Experiences.Migration.Configuration;

namespace MS.Experiences.Weather
{
    public class MeteoFranceDataService : IWeatherForecastService
    {
        private readonly IConfigurationProvider _configProvider;

        public MeteoFranceDataService()
        {
           // _configProvider = configProvider;
        }

        public IEnumerable<WeatherForecast> GetWeatherForecasts(int startDateIndex)
        {
            int temperatureMinimum = 0;//this._configProvider.GetWeatherConfig().TemperatureMin;
            int temperatureMaximum = 50;//this._configProvider.GetWeatherConfig().TemperatureMax;

            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                DateFormatted = DateTime.Now.AddDays(index + startDateIndex).ToShortDateString(),
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
