using SmallFry;

namespace ApprovalTests.Asp.Tests
{
    public static class SmallFryConfig
    {
        public static void RegisterServices(IServiceCollection services)
        {
            /*
             * Register your services here. You should call this method from
             * Application_Start in Global.asax, like so:
             * 
             * SmallFryConfig.RegisterServices(ServiceHost.Instance.Services);
             *
             * If you haven't changed the default Web.config entries, services
             * should be registered under "/api", like so:
             *
             * services
             *     .WithService("Hello, Service!", "/api")
             *         .WithEndpoint("{route}/pattern/{?here}")
             *             .Get(() => { ... });
             */
        }
    }
}