using Microsoft.AspNetCore.Mvc;

namespace MS.Experiences.WebCore.Controllers
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