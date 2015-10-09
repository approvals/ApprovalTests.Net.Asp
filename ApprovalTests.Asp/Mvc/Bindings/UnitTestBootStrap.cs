using System;
using System.Diagnostics;
using System.Web;
using System.Web.Mvc;
using ApprovalUtilities.SimpleLogger;
using ApprovalUtilities.SimpleLogger.Writers;

namespace ApprovalTests.Asp.Mvc.Bindings
{

    public class UnitTestBootStrap
    {
        [Conditional("DEBUG")]
        public static void Register(HttpApplication mvcApplication)
        {
                ControllerBuilder.Current.SetControllerFactory(typeof(UnitTestControllerFactory));
           
        }

       
    }
}
