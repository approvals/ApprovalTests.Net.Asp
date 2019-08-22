using ApprovalTests.Asp.Mvc;
using MvcApplication1.Controllers;
using System.Web.Mvc;
using ApprovalUtilities.Asp.Mvc;

namespace ApprovalTests.Asp.Tests.Mvc
{
    public class TestableWithInvalidPathController : TestableController<CoolController>
    {
        public TestableWithInvalidPathController(CoolController coolController)
            : base(coolController)
        {

        }

        public ActionResult IndexTest()
        {
            var a = SmallFry.EncodingType.Empty;
            return Content("From ApprovalTests.Asp.Tests.Mvc.TestableWithInvalidPathController.IndexTest");
        }
    }
}
