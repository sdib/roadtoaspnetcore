namespace MS.Exeriences.WheatherForecast
{
    public interface IWheatherFactory
    {
        IWheatherForecastService GetDataService(string country);
    }
}