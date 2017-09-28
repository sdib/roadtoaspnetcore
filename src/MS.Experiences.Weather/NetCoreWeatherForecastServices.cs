using Microsoft.Extensions.DependencyInjection;
using MS.Experiences.Migration;
using MS.Experiences.Migration.Configuration;

namespace MS.Experiences.Weather
{
    public static class NetCoreWeatherForecastServices
    {
        public static void Register(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IWeatherForecastService, MeteoFranceDataService>();
            serviceCollection.AddTransient<IWeatherDataServiceFactory, WeatherDataServiceFactory>();
            serviceCollection.AddTransient<IConfigurationProvider, AspNetCoreConfigurationProvider>();
            serviceCollection.AddTransient<IDependencyResolver, AspNetCoreDependencyResolver>();
        }
    }
}