using ApprovalTests.Asp.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ApprovalTests.Asp.Tests.Mvc
{
    [TestClass]
    public class InvalidPathTest
    {
        //TODO: We need to work on this
        [TestMethod]
        public void TestErrorMessage()
        {
            MvcApprovals.VerifyMvcPage<TestableWithInvalidPathController>(t => t.IndexTest);
        }
    }
}