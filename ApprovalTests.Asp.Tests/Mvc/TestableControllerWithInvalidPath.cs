using System.Web.Mvc;
using ApprovalUtilities.Asp.Mvc;
using MvcApplication1.Controllers;
using SmallFry;

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
            var a = EncodingType.Empty;
            return Content("From ApprovalTests.Asp.Tests.Mvc.TestableWithInvalidPathController.IndexTest");
        }
    }
}