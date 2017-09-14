using log4net.Config;
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
            XmlConfigurator.Configure();
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
            app.UseLog();
        }
    }
}
