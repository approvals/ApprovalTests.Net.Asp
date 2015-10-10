using System.Web.Mvc;
using ApprovalTests.Asp.Mvc;
using ApprovalTests.Reporters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcApplication1.Controllers;

namespace ApprovalTests.Asp.Tests.Mvc
{
    [TestClass]
    [UseReporter(typeof (DiffReporter), typeof (FileLauncherReporter))]
    public class ErrorMessageTest : MvcTestBase
    {
        [TestMethod]
        public void TestMvcPage()
        {
            MvcApprovals.VerifyMvcPage<TestableNonExplicitController>(c => c.TestIndex);
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