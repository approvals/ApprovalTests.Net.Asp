using System.Diagnostics;
using System.Web.Mvc;
using ApprovalUtilities.SimpleLogger;

namespace ApprovalTests.Asp.Mvc.Bindings
{

    public class UnitTestBootStrap
    {
        [Conditional("DEBUG")]
        public static void Register()
        {
            using (Logger.MarkEntryPoints())
            {
                ControllerBuilder.Current.SetControllerFactory(typeof(UnitTestControllerFactory));
                Logger.Variable("factory", ControllerBuilder.Current.GetControllerFactory().GetType().FullName);
            }
           
           
        }
    }
}
