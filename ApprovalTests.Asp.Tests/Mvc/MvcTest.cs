using System.Web.Mvc;
using ApprovalTests.Asp.Mvc;
using ApprovalTests.Reporters;
using ApprovalUtilities.Asp.Mvc;
using CassiniDev;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcApplication1;
using MvcApplication1.Controllers;
using MvcApplication1.Models;

namespace ApprovalTests.Asp.Tests.Mvc
{
    [TestClass]
    [UseReporter(typeof (DiffReporter), typeof (FileLauncherReporter))]
    public class MvcTest
    {
        //TODO: Note: We are using ApprovalTests.Asp.Tests.AssemblyStart. 
        //TODO: Note: if you don't use that you have to uncomment the bellow code to make it work.

        //private readonly CassiniDevServer server = new CassiniDevServer();

        [TestInitialize]
        public void Setup()
        {
            //PortFactory.MvcPort = 11625;
            //this.server.StartServer(MvcApplication.Path, PortFactory.MvcPort, "/", "localhost");
        }

        [TestMethod]
        public void TestMvcPage()
        {
            MvcApprovals.VerifyMvcPage<TestableExampleController>(c => c.TestName);
        }


        [TestCleanup]
        public void TearDown()
        {
            //this.server.StopServer();
        }
    }

    public class TestableExampleController : TestableController<ExampleController>
    {
        public TestableExampleController(ExampleController t)
            : base(t)
        {
        }

        public ActionResult TestName()
        {
            return ControllerUnderTest.SaveName(new Person { Name = "Henrik" });
        }

        public ActionResult TestToken()
        {
            return ControllerUnderTest.PageWithVerificationToken();
        }
    }
}