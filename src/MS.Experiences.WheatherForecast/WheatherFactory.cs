using System;
using Microsoft.Practices.Unity;

namespace MS.Experiences.WheatherForecast
{
    public class WheatherFactory : IWheatherFactory
    {
        private readonly IUnityContainer _container;

        public WheatherFactory(IUnityContainer container)
        {
            _container = container;
        }

        public IWheatherForecastService GetDataService(string country)
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
