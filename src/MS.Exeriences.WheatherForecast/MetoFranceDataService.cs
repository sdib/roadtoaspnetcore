using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Exeriences.WheatherForecast
{
    public class MeteoFranceDataService
    {


        public IEnumerable<WeatherForecast> GetWeatherForecasts(int startDateIndex)
        {
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
