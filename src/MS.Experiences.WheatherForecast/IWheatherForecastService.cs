using System.Collections.Generic;

namespace MS.Experiences.WheatherForecast
{
    public interface IWheatherForecastService
    {
        IEnumerable<WeatherForecast> GetWeatherForecasts(int startDateIndex);
    }
}