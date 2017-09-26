using System;
using Microsoft.Practices.Unity;

namespace MS.Experiences.Weather
{
    public class WeatherDataServiceFactory : IWeatherDataServiceFactory
    {
        private readonly IUnityContainer _container;

        public WeatherDataServiceFactory(IUnityContainer container)
        {
            _container = container;
        }

        public IWeatherForecastService GetDataService(string country)
        {
            switch (country)
            {
                case "belgique":
                    return _container.Resolve<MeteoBelgiqueDataService>();
                case "france":
                    return _container.Resolve<MeteoFranceDataService>();
                default:
                    throw new ArgumentException("This country is not available");
            }

        }
    }
}
