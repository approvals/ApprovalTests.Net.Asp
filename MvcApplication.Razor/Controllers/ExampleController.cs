using System.Web.Mvc;
using ApprovalUtilities.Asp.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class ExampleController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SaveName(Person person)
        {
            return View(person).Explicit();
            /*
             * .Explicit() 
             * is the same as 
             * View("SaveName", person);
             * and allows the view to work when called from the test controller
             */

        }
    }
}