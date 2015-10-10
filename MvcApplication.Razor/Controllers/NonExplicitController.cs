using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class NonExplicitController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}