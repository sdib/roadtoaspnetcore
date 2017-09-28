using AF.AxaConnect.Infrastructure.Logging;
using log4net.Config;
using Microsoft.Extensions.Logging;
using Microsoft.Owin;
using MS.Experiences.Web.Middlewares;
using Owin;

[assembly: OwinStartup(typeof(MS.Experiences.Web.Startup))]

namespace MS.Experiences.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var webApiConfigBuilder = new WebApiConfigurationBuilder();
            
            app.UseLog();

            app.UseWebApi(webApiConfigBuilder.Build());
        }
    }
}
