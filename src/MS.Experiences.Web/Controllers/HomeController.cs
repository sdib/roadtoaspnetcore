using log4net;
using System.Web.Mvc;

namespace MS.Experiences.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILog log = log4net.LogManager.GetLogger(typeof(HomeController));
        
        public ActionResult Index()
        {
            log.Info("Requesting Index");
            return View();
        }

        public ActionResult About()
        {
            log.Info("Requesting About");
            ViewBag.Message = "Microsoft love linux!";
            return View();
        }

    }
}