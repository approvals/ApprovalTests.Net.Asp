using ApprovalTests.Asp.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
