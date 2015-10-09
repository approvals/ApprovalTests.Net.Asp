using System.Web.Mvc;
using ApprovalTests.Asp.Mvc;
using ApprovalUtilities.Asp.Mvc;
using MvcApplication1.Controllers;
using MvcApplication1.Models;

namespace ApprovalTests.Asp.Tests.Mvc
{
    public class CoolTestableController : TestableController<CoolController>
    {
        public CoolTestableController(CoolController t) : base(t)
        {
        }

    
        public ActionResult TestName()
        {
            //return MvcUtilites.CallViewResult(ControllerUnderTest.SaveName, new Person { Name = "Henrik" });
            return ControllerUnderTest.SaveName(new Person {Name = "Henrik"});
        }
       
    }
}