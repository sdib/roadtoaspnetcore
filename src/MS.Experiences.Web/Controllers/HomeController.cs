using log4net;
using System.Web.Mvc;

namespace MS.Experiences.Web.Controllers
{
    public class HomeController : Controller
    {
        private ILog log = log4net.LogManager.GetLogger(typeof(HomeController));
        
        public ActionResult Index()
        {
            log.Info("Requesting Index");
            return View();
        }

        public ActionResult About()
        {
            log.Info("Requesting About");

            ViewBag.Message = "Your application description page.";

            return View();
        }

    }
}