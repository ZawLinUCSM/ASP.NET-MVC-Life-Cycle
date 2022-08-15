using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RouxAcademy.Filters
{
    public class CustomActionFilterAttribute: ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string controllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;

            string actionName = filterContext.ActionDescriptor.ActionName;

            Trace.WriteLine(string.Format("Before action execution - Controller Name: {0} Action Name: {1}", controllerName, actionName));
        }
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            string controllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;

            string actionName = filterContext.ActionDescriptor.ActionName;

            Trace.WriteLine(string.Format("After action execution - Controller Name: {0} Action Name: {1}", controllerName, actionName));
        }
    }
}