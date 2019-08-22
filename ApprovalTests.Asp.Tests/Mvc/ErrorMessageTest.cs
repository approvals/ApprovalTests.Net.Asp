using System.Web.Mvc;
using ApprovalTests.Asp.Mvc;
using ApprovalUtilities.Asp.Mvc;
using ApprovalUtilities.Asp.Mvc.Bindings;
using ApprovalTests.Reporters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcApplication1.Controllers;

namespace ApprovalTests.Asp.Tests.Mvc
{
    [TestClass]
    [UseReporter(typeof (DiffReporter), typeof (FileLauncherReporter))]
    public class ErrorMessageTest
    {
        [TestMethod]
        public void TestMvcPage()
        {
            MvcApprovals.VerifyMvcPage<TestableNonExplicitController>(c => c.TestIndex);
        }

        [TestMethod]
        public void TestImproperlyNamedConroller()
        {
            MvcApprovals.VerifyMvcPage<ThisDoesNotHaveTheControllerAtTheEnd>(c => c.TestIndex);
        }
    }


    public class ThisDoesNotHaveTheControllerAtTheEnd : TestableController<CoolController>
    {
        public ThisDoesNotHaveTheControllerAtTheEnd(CoolController coolController)
            : base(coolController)
        {
        }

        public ActionResult TestIndex()
        {
            return Content("From ThisDoesNotHaveTheControllerAtTheEnd.TestIndex");
        }
    }


    public class TestableNonExplicitController : TestableController<NonExplicitController>
    {
        public TestableNonExplicitController(NonExplicitController t)
            : base(t)
        {
        }

        public ActionResult TestIndex()
        {
            return ControllerUnderTest.Index();
        }
    }
}