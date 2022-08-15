using LoggerService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomDependencyResolverService
{
    public class CustomDependencyResolver : IDependencyResolver
    {
        public object GetService(Type serviceType)
        {
            if(serviceType == typeof(ILogger))
            {
                return new Logger();
            }

            return null;
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return Enumerable.Empty<object>();
        }
    }
}