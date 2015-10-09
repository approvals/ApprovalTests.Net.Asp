#if !__MonoCS__

using System.Collections.Specialized;
using ApprovalTests.Asp;
using ApprovalTests.Asp.Mvc;
using ApprovalTests.Reporters;
using CassiniDev;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcApplication1;
using MvcApplication1.Controllers;
using MvcApplication1.Models;

namespace ApprovalTests.Tests.Asp.Mvc
{
    public class MvcTest
    {
        [TestClass]
        [UseReporter(typeof (DiffReporter), typeof (AllFailingTestsClipboardReporter))]
        public class TryingMvcViewApproval
        {
            private readonly CassiniDevServer server = new CassiniDevServer();

            [TestInitialize]
            public void Setup()
            {
                PortFactory.MvcPort = 11625;
                this.server.StartServer(MvcApplication.Path, PortFactory.MvcPort, "/", "localhost");
            }

            [TestCleanup]
            public void TearDown()
            {
                this.server.StopServer();
            }

            [TestMethod]
            public void TestingSomeMvcView()
            {
                // AspApprovals.VerifyUrlViaPost("http://localhost:11625/Cool/Index");
                MvcApprovals.VerifyMvcPage(new CoolController().Index);
            }

            [TestMethod]
            public void TestingSomeMvcViewWithGenerics()
            {
            //    MvcApprovals.VerifyMvcPage<CoolController>(c => c.Index);
            }

            [TestMethod]
            public void TestingPostView()
            {
                MvcApprovals.VerifyUrlViaPost("http://localhost:11625/Cool/SaveName",
                    new NameValueCollection {{"Name", "Henrik"}});
            }

            [TestMethod]
            public void TestingMvcWithPost()
            {
                MvcApprovals.VerifyMvcViaPost<Person>(new CoolController().SaveName,
                    new NameValueCollection {{"Name", "Henrik"}});
            }

            [TestMethod]
            public void TestingMvcWithPost2()
            {
                MvcApprovals.VerifyMvcViaPost(new CoolController().SaveName, new Person {Name = "Henrik"});
            }

#if DEBUG

            [TestMethod]
            public void TestWithName()
            {
                MvcApprovals.VerifyMvcPage(new CoolController().TestName);
            }

#endif
        }
    }
}

#endif