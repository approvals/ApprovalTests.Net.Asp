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
            MvcApprovals.VerifyApprovalBootstrap();
        }
    }
}
