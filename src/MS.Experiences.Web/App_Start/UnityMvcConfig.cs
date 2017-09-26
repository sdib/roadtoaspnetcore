using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using MS.Experiences.Weather;

namespace MS.Experiences.Web
{
    public static class UnityMvcConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            WeatherForecastServices.Register(container);
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}