using ApprovalTests.Asp.Mvc;
using ApprovalTests.Reporters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
