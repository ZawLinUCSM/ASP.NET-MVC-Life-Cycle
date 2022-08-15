using LoggerService;
using RouxAcademy.Filters;
using RouxAcademy.Models.HomeViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RouxAcademy.Controllers
{
    [CustomActionFilter]
    public class HomeController : Controller
    {
        private readonly ILogger _logger;

        public HomeController()
        {

        }
        public HomeController(ILogger logger)
        {
            _logger = logger;
        }
        public ActionResult Index()
        {
            _logger.Log("Home Index action");

            return View();
        }

        public ActionResult About()
        {
            var logger = DependencyResolver.Current.GetService<ILogger>();

            logger.Log("Home About action");

            return View();
        }

        public ActionResult Programs()
        {
            return View();
        }
        [Route("Academics/Detail/{id:int?}")]
        public ActionResult ProgramDetails(int id)
        {
            return Content("Program Details");
        }

        public ActionResult Spotlight()
        {
            return View();
        }
        [HttpGet]
        [ActionName("Contact")]
        public ActionResult ContactUs()
        {
            return View("ContactUs");
        }
        [AcceptVerbs(HttpVerbs.Post)]
        [ActionName("Contact")]
        public ActionResult ContactUs(ContactViewModel contact)
        {
            //TODO: Forward contact info to support team

            return View("ContactUs", contact);
        }
    }
}