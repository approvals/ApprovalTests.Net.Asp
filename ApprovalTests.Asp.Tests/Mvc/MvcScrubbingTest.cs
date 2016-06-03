using ApprovalTests.Asp.Mvc;
using ApprovalTests.Reporters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ApprovalTests.Asp.Tests.Mvc
{
    [TestClass]
    [UseReporter(typeof (DiffReporter), typeof (FileLauncherReporter))]
    public class MvcScrubbingTest
    {
     

        [TestMethod]
        public void TestMvcPage()
        {
            MvcApprovals.VerifyMvcPage<TestableExampleController>(c => c.TestToken);
        }


    }

 
}