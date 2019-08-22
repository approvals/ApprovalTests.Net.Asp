using ApprovalTests.Asp;
using ApprovalTests.Reporters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcApplication1;

namespace ApprovalTests.Tests.Asp
{
    [TestClass]
    [UseReporter(typeof(ClipboardReporter))]
    public class RoutingTest
    {
        [TestMethod]
        public void TestRoutes()
        {
            var urls = new[] {"/Home/Index/Hello", "/"};
            AspApprovals.VerifyRouting(MvcApplication.RegisterRoutes, urls);
        }

        [TestMethod]
        public void TestMissingRoutes()
        {
            AspApprovals.VerifyRouting(r => { }, "/");
        }
    }
}