using CassiniDev;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcApplication1;

namespace ApprovalTests.Asp.Tests.Mvc
{
    public class MvcTestBase
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
    }
}