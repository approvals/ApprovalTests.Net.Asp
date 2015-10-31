using System;
using System.Linq;
using System.Web.Mvc;
using ApprovalUtilities.Utilities;

namespace ApprovalTests.Asp.Mvc.Bindings
{
    public class IllegalAccesMessageController : Controller
    {
        public ActionResult Display(String theMessage)
        {
            string message = @"<pre>
The assembly:
{0}

Is not allowed.
If you would like to allow this assembly. 
Please add a filter to your Global.asax page like

UnitTestBootStrap.RegisterWithDebugCondition(""{1}"");
</pre>".FormatWith(theMessage, theMessage.Split('\\').Last());

            return Content(message);
        }

        public ActionResult DisplayAssemblyNotReferedInMainProject(String theMessage)
        {
            string message = @"<pre>
You MVC Project is missing a dll test project referencing
{0}
</pre>".FormatWith(theMessage);

            return Content(message);
        }
    }
}