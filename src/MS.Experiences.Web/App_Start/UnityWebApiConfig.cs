using System.Web.Http;
using Microsoft.Practices.Unity;
using MS.Experiences.Weather;

namespace MS.Experiences.Web
{
    public class UnityWebApiConfig
    {
        public static void RegisterComponents(HttpConfiguration configuration)
        {
            var container = new UnityContainer();
            WeatherForecastServices.Register(container);

            configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
        }
    }
}