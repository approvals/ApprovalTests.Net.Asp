using System.Linq;
using System.Web.Mvc;
using ApprovalUtilities.CallStack;

namespace ApprovalUtilities.Asp.Mvc
{
    public class ControllerWithExplicitViews : Controller
    {
        protected override ViewResult View(string viewName, string masterName, object model)
        {
            if (viewName == null)
            {
                viewName = FindViewName();
            }
            return base.View(viewName, masterName, model);
        }

        private string FindViewName()
        {
            return new Caller().Methods.First(m => m.Name != "View").Name;
        }
    }
}