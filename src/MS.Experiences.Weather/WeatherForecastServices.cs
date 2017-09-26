using Microsoft.Practices.Unity;

namespace MS.Experiences.Weather
{
    public static class WeatherForecastServices
    {
        public static void Register(IUnityContainer unityContainer)
        {
            unityContainer.RegisterType<IWeatherForecastService, MeteoFranceDataService>();
            unityContainer.RegisterType<IWeatherDataServiceFactory, WeatherDataServiceFactory>();
        }
    }
}
