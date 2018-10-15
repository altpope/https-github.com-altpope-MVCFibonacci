using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.Mvc;
using Web.Services;
using Web.Controllers;

namespace Web
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            var ioc_builder = new ContainerBuilder();

            ioc_builder.RegisterType<FibonacciService>().As<IFibonacciService>().InstancePerDependency();
            ioc_builder.RegisterType<FibonacciController>().InstancePerRequest();
            var ioc_container = ioc_builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(ioc_container));

            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
