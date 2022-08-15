using CustomDependencyResolverService;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace RouxAcademy
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected DateTime requestStartTime;

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ControllerBuilder.Current.SetControllerFactory(new CustomControllerFactory());

            DependencyResolver.SetResolver(new CustomDependencyResolver());

            Application["ApplicationStartDateTime"] = DateTime.Now;

            ViewEngines.Engines.Clear();

            ViewEngines.Engines.Add(new CustomViewEngine());
        }
        protected void Application_End()
        {
            Application.Clear();
        }
        protected void Application_BeginRequest(Object sender, EventArgs e)
        {
            requestStartTime = DateTime.Now;

            Trace.WriteLine(String.Format("Request Start Time: {0}", requestStartTime));
        }
        protected void Application_EndRequest(Object sender, EventArgs e)
        {
            TimeSpan totalRequestTime = DateTime.Now - requestStartTime;

            Trace.WriteLine(String.Format("Request Time: {0} ms", totalRequestTime.TotalMilliseconds));
        }
    }
}
