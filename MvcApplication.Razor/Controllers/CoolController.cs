using System.Web.Mvc;
using ApprovalTests.Asp.Mvc.Bindings;
using ApprovalUtilities.Asp.Mvc;
using ApprovalUtilities.SimpleLogger;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
	public partial class CoolController : Controller
	{
		//
		// GET: /Cool/

		public ActionResult Index()
		{
            Logger.Variable("controller", ControllerBuilder.Current.GetControllerFactory());
            return View();
		}

		[HttpPost]
		public ActionResult SaveName(Person person)
		{
			return View(person).Explicit();
		}


	}

#if DEBUG
	public partial class CoolController
	{
		public ActionResult TestName()
		{
			return MvcUtilites.CallViewResult(SaveName, new Person { Name = "Henrik" });
		}
	}
#endif
}
