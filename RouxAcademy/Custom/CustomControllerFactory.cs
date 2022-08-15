using LoggerService;
using RouxAcademy.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;

namespace RouxAcademy
{
    public class CustomControllerFactory : IControllerFactory
    {
        public IController CreateController(RequestContext requestContext, string controllerName)
        {
            Type controllerType = null;
            ILogger logger = new Logger();

            if(controllerName == "Home")
            {
                controllerType = typeof(HomeController);
            }
            if (controllerName == "Course")
            {
                controllerType = typeof(CourseController);
            }

            IController controller = (IController) Activator.CreateInstance(controllerType, logger);

            return controller;
        }

        public SessionStateBehavior GetControllerSessionBehavior(RequestContext requestContext, string controllerName)
        {
            return SessionStateBehavior.Default;
        }

        public void ReleaseController(IController controller)
        {

        }
    }
}