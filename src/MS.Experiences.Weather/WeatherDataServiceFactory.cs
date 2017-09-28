using System;
using MS.Experiences.Migration;

namespace MS.Experiences.Weather
{
    public class WeatherDataServiceFactory : IWeatherDataServiceFactory
    {
        private readonly IDependencyResolver _resolver;

        public WeatherDataServiceFactory(IDependencyResolver resolver)
        {
            _resolver = resolver;
        }

        public IWeatherForecastService Get(string country)
        {
            switch (country)
            {
                case "belgique":
                    return _resolver.Resolve<MeteoBelgiqueDataService>();
                case "france":
                    return _resolver.Resolve<MeteoFranceDataService>();
                default:
                    throw new NotSupportedException("This country is not supported");
            }

        }
    }
}
