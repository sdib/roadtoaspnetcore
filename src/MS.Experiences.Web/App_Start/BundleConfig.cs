using System.Web;
using System.Web.Optimization;

namespace MS.Experiences.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/vendors").Include(
                        "~/Scripts/angular.js"));

            bundles.Add(new ScriptBundle("~/bundles/demo").Include(
                      "~/App/meteo/index.js",
                      "~/App/meteo/meteo.factory.js",
                      "~/App/meteo/meteo.component.js",
                      "~/App/app.run.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/App/app.css",
                      "~/App/meteo/meteo.css"
                      ));
        }
    }
}
