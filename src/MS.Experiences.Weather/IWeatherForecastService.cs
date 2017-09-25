using System.Collections.Generic;

namespace MS.Experiences.Weather
{
    public interface IWeatherForecastService
    {
        IEnumerable<WeatherForecast> GetWeatherForecasts(int startDateIndex);
    }
}