using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CustomHttpModule
{
    public class LoggingHttpModule : IHttpModule
    {
        public void Dispose()
        {
        }

        public void Init(HttpApplication context)
        {
            context.LogRequest += Application_LogRequest;
        }

        private void Application_LogRequest(object sender, EventArgs e)
        {
            HttpApplication application = (HttpApplication)sender;
            HttpContext context = application.Context;

            string requestPath = context.Request.Path;

            Trace.WriteLine(String.Format("Request Path: {0}", requestPath));
        }
    }
}
