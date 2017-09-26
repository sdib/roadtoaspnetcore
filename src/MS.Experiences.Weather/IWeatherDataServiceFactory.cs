namespace MS.Experiences.Weather
{
    public interface IWeatherDataServiceFactory
    {
        IWeatherForecastService Get(string country);
    }
}