using Microsoft.Extensions.Logging;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AF.AxaConnect.Infrastructure.Logging;
using log4net.Repository.Hierarchy;

namespace MS.Experiences.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            UnityMvcConfig.RegisterComponents();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
