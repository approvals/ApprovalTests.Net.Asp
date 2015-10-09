using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ApprovalTests.Core.Asp.Mvc
{

    public class UnitTestBootStrap
    {
        [Conditional("DEBUG")]
        public static void Register()
        {
            ControllerBuilder.Current.SetControllerFactory(typeof(UnitTestControllerFactory));
        }
    }
}
