using System.Web.Http;

namespace MS.Experiences.Web
{
    public class WebApiConfigurationBuilder
    {
        public HttpConfiguration Build()
        {
            var config = new HttpConfiguration();
            UnityWebApiConfig.RegisterComponents(config);
            config.MapHttpAttributeRoutes();

            config.Formatters.Remove(config.Formatters.XmlFormatter);

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            return config;
        }
    }
}