using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ApprovalTests.Core.Asp.Mvc
{
    public class UnitTestActionInvoker : ControllerActionInvoker
    {
        public override bool InvokeAction(ControllerContext controllerContext, string actionName)
        {
            return base.InvokeAction(controllerContext, HttpContext.Current.Request.QueryString["testAction"] ?? actionName);
        }
    }
}
