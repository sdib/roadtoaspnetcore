using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Exeriences.WheatherForecast
{
    public class MockDataService 
    {
        IEnumerable<WeatherForecast> GetWeatherForecasts(int startDateIndex)
        {
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
