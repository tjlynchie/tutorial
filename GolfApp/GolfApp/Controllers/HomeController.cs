using GolfApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GolfApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            return View();
            //return "Hello Golf!!";
        }

        [HttpGet]
        public ViewResult Registration()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Registration(GolfRegistration golfRegistration)
        {
            return View("Confirm", golfRegistration);
        }
    }
}