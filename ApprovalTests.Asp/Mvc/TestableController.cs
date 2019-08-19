using System;
using System.Web.Mvc;
using ApprovalUtilities.Utilities;
using System.IO;
using ApprovalTests.Asp.Mvc.Bindings;

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

            var fileNotfoundException = ex as FileNotFoundException;

            var message = $@"<pre>
Exception Thrown on Server.
If this is a 'View not Found' the most likely reason is your ActionResult is being calculated incorrectly. 

There are 2 ways to fix this.
1) Instead of extending Controller, extend ControllerWithExplicitViews
For Example:
   (wrong) ExampleController : Controller
   (right) ExampleController : ControllerWithExplicitViews
or 

2) add .Explicit() to your ViewResult

For Example:
 (wrong) return View();
 (right) return View().Explicit();

Message: {ex.Message}
</pre>";

            filterContext.Result = fileNotfoundException != null ?
                new ContentResponseMessageController().DisplayAssemblyNotReferedInMainProject(fileNotfoundException.Message) :
                new ContentResult { Content = message };

        }


    }
}