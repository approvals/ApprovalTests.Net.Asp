﻿using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using ApprovalTests.Asp.Mvc.Bindings;
using ApprovalUtilities.Utilities;

namespace MvcApplication1
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : HttpApplication
    {
        public static string Path
        {
            get { return PathUtilities.GetDirectoryForCaller(); }
        }

        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Cool", action = "Index", id = UrlParameter.Optional } // Parameter defaults
                );
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);

            UnitTestBootStrap.RegisterWithDebugCondition("ApprovalTests.Asp.Tests");
            //UnitTestBootStrap.RegisterWithTestCondition("ApprovalTests.Asp.Tests");
        }

    }


}