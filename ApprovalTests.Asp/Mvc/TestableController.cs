using System;
using System.Web.Mvc;
using ApprovalUtilities.Utilities;

namespace ApprovalTests.Asp.Mvc
{
    public class TestableController<T> : TestableControllerBase
        where T : class, IController
    {
        public TestableController(T t)
            : base(t)
        {
        }

        public T ControllerUnderTest
        {
            get { return GenericControllerUnderTest as T; }
        }
    }

    public class TestableControllerBase : Controller
    {
        public TestableControllerBase(IController controllerUnderTest)
        {
            GenericControllerUnderTest = controllerUnderTest;
        }

        protected IController GenericControllerUnderTest { get; private set; }

        protected override void OnException(ExceptionContext filterContext)
        {
            Exception ex = filterContext.Exception;
            filterContext.ExceptionHandled = true;

            var model = new HandleErrorInfo(filterContext.Exception, "Controller", "Action");
            var e = ex as InvalidOperationException;
            var message = @"<pre>
Exception Thrown on Server.
If this is a 'View not Found' the most likely reason is your ActionResult is being calculated incorrectly. 
Please add .Explicit() to your ViewResult

For Example:
 (wrong) return View();
 (right) return View().Explicit();

Message: {0}
Stack Trace:
{1} 
</pre>".FormatWith(ex.Message, ex.StackTrace);
            filterContext.Result = new ContentResult{Content = message};

        }
    }
}