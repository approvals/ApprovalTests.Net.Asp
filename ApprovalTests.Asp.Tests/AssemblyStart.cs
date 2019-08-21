using CassiniDev;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcApplication1;
using ApprovalTests.Namers.StackTraceParsers;

namespace ApprovalTests.Asp.Tests
{
    [TestClass]
    public class AssemblyStart
    {
        private static readonly CassiniDevServer server = new CassiniDevServer();

        [AssemblyInitialize()]
        public static void AssemblyInit(TestContext context)
        {
            PortFactory.MvcPort = 11625;
            server.StartServer(MvcApplication.Path, PortFactory.MvcPort, "/", "localhost");
            AttributeStackTraceParser.FileInfoIsValidFilter = caller => true;

        }

        [AssemblyCleanup()]
        public static void AssemblyCleanup()
        {
            server.StopServer();
        }
    }
}
