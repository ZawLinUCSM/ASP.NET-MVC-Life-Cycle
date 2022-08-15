
using LoggerService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RouxAcademy.Controllers
{
    public class CourseController : Controller
    {
        private readonly ILogger _logger;

        public CourseController()
        {

        }
        public CourseController(ILogger logger)
        {
            _logger = logger;
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}