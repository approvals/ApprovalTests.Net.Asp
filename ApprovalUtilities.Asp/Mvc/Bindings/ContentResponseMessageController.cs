using System.Linq;
using System.Web.Mvc;

namespace ApprovalUtilities.Asp.Mvc.Bindings
{
    public class ContentResponseMessageController : Controller
    {
        public ActionResult Echo(string theMessage)
        {
            var message = $@"<pre> 
If you are seeing this then ApprovalTests.Asp.Bootstrap is setup correctly

Echoing 
'{theMessage}'

</pre>";

            return Content(message);
        }

        public ActionResult Display(string theMessage)
        {
            var message = $@"<pre>
The assembly:
{theMessage}

Is not allowed.
If you would like to allow this assembly. 
Please add a filter to your Global.asax page like

UnitTestBootStrap.RegisterWithDebugCondition(""{theMessage.Split('\\').Last()}"");
</pre>";

            return Content(message);
        }

        public ActionResult DisplayAssemblyNotReferedInMainProject(string theMessage)
        {
            var message = $@"<pre>
You MVC Project is missing a dll test project referencing
{theMessage}
</pre>";

            return Content(message);
        }
    }
}