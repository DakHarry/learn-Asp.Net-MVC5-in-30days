using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProject.Controllers
{
    //[RoutePrefix("Home")]
    //[Route("{action=Index}")]
    public class HomeController : Controller
    {
        //[Route("~/")]
        //[Route("Home")]
        //[Route("This-is-Attribute-Routing-Test-Url")]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}