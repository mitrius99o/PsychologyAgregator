using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PsyAgregator.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutTherapy()
        {
            return View();
        }

        public IActionResult Importance()
        {
            return View();
        }

        public IActionResult SiteWork()
        {
            return View();
        }

        public IActionResult Test()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }
    }
}
