using System.Collections.Generic;

namespace MS.Exeriences.WheatherForecast
{
    public interface IWheatherForecastService
    {
        IEnumerable<WeatherForecast> GetWeatherForecasts(int startDateIndex);
    }
}