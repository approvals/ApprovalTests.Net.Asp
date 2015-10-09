using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace ApprovalTests.Asp.Mvc
{
    public class TestableController<T> : TestableControllerBase
        where T : class, IController
    {
        public TestableController(T t)
            : base(t)
        { }

        public T ControllerUnderTest { get { return GenericControllerUnderTest as T; } }
    }

    public class TestableControllerBase : Controller
    {
        public TestableControllerBase(IController controllerUnderTest)
        {
            GenericControllerUnderTest = controllerUnderTest;
        }

        protected IController GenericControllerUnderTest { get; private set; }
    }
}
