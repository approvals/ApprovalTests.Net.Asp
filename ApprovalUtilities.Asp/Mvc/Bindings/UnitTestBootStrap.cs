using System.Diagnostics;
using System.Web.Mvc;

namespace ApprovalUtilities.Asp.Mvc.Bindings
{
    public class UnitTestBootStrap
    {
        /// <summary>
        /// This will only execute if you have added custom tag "TEST" in Properties -> Build -> Conditional Compilation Symbols
        /// alternatively you can add <PropertyGroup> <DefineConstants>TRACE;DEBUG;TEST</DefineConstants> </PropertyGroup> to your .csproj/.vbproj file
        /// </summary>
        /// <param name="allowedDlls"></param>
        [Conditional("TEST")]
        public static void RegisterWithTestCondition(params string[] allowedDlls)
        {
            RegisterForAllCondition_WarningUnsafe(allowedDlls);
        }

        /// <summary>
        /// This works only "DEBUG" Mode
        /// </summary>
        /// <param name="allowedDlls"></param>
        [Conditional("DEBUG")]

        public static void RegisterWithDebugCondition(params string[] allowedDlls)
        {
            RegisterForAllCondition_WarningUnsafe(allowedDlls);
        }

        private static void RegisterForAllCondition_WarningUnsafe(params string[] allowedDlls)
        {
            UnitTestControllerFactory.ALLOWED_DLLS = allowedDlls;
            ControllerBuilder.Current.SetControllerFactory(typeof(UnitTestControllerFactory));
        }
    }
}