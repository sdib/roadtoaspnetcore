namespace MS.Experiences.WheatherForecast
{
    public interface IWheatherFactory
    {
        IWheatherForecastService GetDataService(string country);
    }
}