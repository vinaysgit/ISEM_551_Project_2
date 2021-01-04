using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business;

namespace ISEM_551_Web_Application.Controllers
{
    public class HomeController : Controller
    {
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

        public ActionResult DisplayMetropolitanCities()
        {
            var getAllMetropolitanCities = Cities.getAllMetropolitanCities();
            return View(getAllMetropolitanCities);
        }

        [HttpGet]
        public ActionResult DisplayMetropolitanCitiesJSON()
        {
            var getAllMetropolitanCities = Cities.getAllMetropolitanCities();
            return Json(getAllMetropolitanCities, JsonRequestBehavior.AllowGet);
        }
    }
}