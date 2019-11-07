using ApprovalTests.Asp.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ApprovalTests.Asp.Tests.Mvc
{
    [TestClass]
    public class EchoTest
    {
        [TestMethod]
        public void TestBootStrapReady()
        {
            // begin-snippet: verify_bootstrap_configured
            MvcApprovals.VerifyApprovalBootstrap();
            // end-snippet
        }
    }
}