
using System.Web.Mvc;

namespace MS.Experiences.Web.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Microsoft love linux!";
            return View();
        }

    }
}