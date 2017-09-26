namespace MS.Experiences.Weather
{
    public interface IWeatherDataServiceFactory
    {
        IWeatherForecastService GetDataService(string country);
    }
}