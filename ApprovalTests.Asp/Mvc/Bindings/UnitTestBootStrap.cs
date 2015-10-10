using System.Diagnostics;
using System.Web.Mvc;

namespace ApprovalTests.Asp.Mvc.Bindings
{
    public class UnitTestBootStrap
    {
        [Conditional("DEBUG")]
        public static void Register(params string[] allowedDlls)
        {
            UnitTestControllerFactory.ALLOWED_DLLS = allowedDlls;
            ControllerBuilder.Current.SetControllerFactory(typeof (UnitTestControllerFactory));
        }
    }
}