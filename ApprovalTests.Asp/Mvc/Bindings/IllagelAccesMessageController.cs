using System;
using System.Linq;
using System.Web.Mvc;
using ApprovalUtilities.Utilities;

namespace ApprovalTests.Asp.Mvc.Bindings
{
    public class IllagelAccesMessageController : Controller
    {
        public ActionResult Display(String illegalAssemblyPath)
        {
            string message = @"The assembly:
{0}

Is not allowed.
If you would like to allow this assembly. 
Please add a filter to your Global.asax page like

UnitTestBootStrap.Register(""{1}"");".FormatWith(illegalAssemblyPath, illegalAssemblyPath.Split('\\').Last());

            return Content(message);
        }
    }
}