using System;
using System.Collections.Generic;
using log4net;

namespace MS.Experiences.WheatherForecast
{
    public class MeteoMockDataService : IWheatherForecastService
    {
        private readonly ILog log = log4net.LogManager.GetLogger(typeof(MeteoMockDataService));

        public IEnumerable<WeatherForecast> GetWeatherForecasts(int startDateIndex)
        {
            log.Info("Gathering mock wheather info");

            return new List<WeatherForecast>(){
                new WeatherForecast
                {
                    DateFormatted = DateTime.Now.AddDays(1 + startDateIndex).ToString("d"),
                    TemperatureC = 0,
                    Summary = "Freezing"
                },
                new WeatherForecast
                {
                    DateFormatted = DateTime.Now.AddDays(2 + startDateIndex).ToString("d"),
                    TemperatureC = 35,
                    Summary = "Hot"
                },
                new WeatherForecast
                {
                    DateFormatted = DateTime.Now.AddDays(3 + startDateIndex).ToString("d"),
                    TemperatureC = 20,
                    Summary = "Warm"
                }
            };
        }
    }
}
