using System;
using Microsoft.Practices.Unity;
using MS.Experiences.Migration;
using MS.Experiences.Migration.Configuration;

namespace MS.Experiences.Weather
{
    public static class WeatherForecastServices
    {
        public static void Register(IUnityContainer unityContainer)
        {
            unityContainer.RegisterType<IWeatherForecastService, MeteoFranceDataService>();
            unityContainer.RegisterType<IWeatherDataServiceFactory, WeatherDataServiceFactory>();
            unityContainer.RegisterType<IConfigurationProvider, LegacyConfigurationProvider>();
            unityContainer.RegisterType<IDependencyResolver, UnityDependencyResolver>();
        }
    }
}
