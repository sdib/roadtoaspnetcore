namespace MS.Experiences.Weather
{
    public interface IWeatherFactory
    {
        IWeatherForecastService GetDataService(string country);
    }
}