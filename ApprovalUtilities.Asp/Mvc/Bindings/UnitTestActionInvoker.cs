using System.Web;
using System.Web.Mvc;

namespace ApprovalUtilities.Asp.Mvc.Bindings
{
    public class UnitTestActionInvoker : ControllerActionInvoker
    {
        public override bool InvokeAction(ControllerContext controllerContext, string actionName)
        {
            return base.InvokeAction(controllerContext,
                HttpContext.Current.Request.QueryString["testAction"] ?? actionName);
        }

        
    }
}