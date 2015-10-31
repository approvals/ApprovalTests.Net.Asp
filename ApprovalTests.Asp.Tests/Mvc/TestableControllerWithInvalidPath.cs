using ApprovalTests.Asp.Mvc;
using MvcApplication1.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace ApprovalTests.Asp.Tests.Mvc
{
    public class TestableWithInvalidPathController : TestableController<CoolController>
    {
        public TestableWithInvalidPathController(CoolController coolController)
            : base(coolController)
        {

        }

        public ActionResult IndexTest()
        {
            return Content("From ApprovalTests.Asp.Tests.Mvc.TestableWithInvalidPathController.IndexTest");
        }
    }
}
