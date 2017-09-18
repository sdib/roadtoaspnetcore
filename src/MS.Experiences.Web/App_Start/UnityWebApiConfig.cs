using System.Web.Http;
using Microsoft.Practices.Unity;
using MS.Exeriences.WheatherForecast;

namespace MS.Experiences.Web
{
    public class UnityWebApiConfig
    {
        public static void RegisterComponents(HttpConfiguration configuration)
        {
            var container = new UnityContainer();
            WheatherForecastServices.Register(container);

            configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
        }
    }
}