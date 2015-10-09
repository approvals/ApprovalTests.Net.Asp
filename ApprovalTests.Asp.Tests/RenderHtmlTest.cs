# if DEBUG && !__MonoCS__
using ApprovalTests.Asp;
using ApprovalTests.Reporters;
using ApprovalTests.Scrubber;
using Asp.Net.Demo;
using Asp.Net.Demo.Orders;
using CassiniDev;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ApprovalTests.Tests.Asp
{
	[TestClass]
	[UseReporter(typeof (DiffReporter), typeof (FileLauncherReporter))]
	public class RenderHtmlTest
	{
		private CassiniDevServer server = new CassiniDevServer();

		[TestInitialize]
		public void Setup()
		{
			PortFactory.AspPort = 1359;
			server.StartServer(Global.Path, PortFactory.AspPort, "/", "localhost");
		}

		[TestCleanup]
		public void TearDown()
		{
			server.StopServer();
		}

		[TestMethod]
		public void TestSimpleInvoice()
		{
			AspApprovals.VerifyAspPage(new InvoiceView().TestSimpleInvoice, HtmlScrubbers.ScrubAsp);

			//  -- These are the same thing
			//AspApprovals.VerifyUrl("http://localhost:1359/Orders/InvoiceView.aspx?TestSimpleInvoice");
		}

		[TestMethod]
		public void TestInternationalization()
		{
			AspApprovals.VerifyUrl("http://localhost:1359/Encoding.UTF8.html", HtmlScrubbers.ScrubBrowserLink);
		}
	}
}

#endif