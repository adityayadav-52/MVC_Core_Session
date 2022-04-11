using CoreSession.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CoreSession.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.a = "Hii from Chetu Inc";
            ViewBag.a1 = 1234;
            ViewBag.a2 = 12.2f;
            ViewBag.a3 = DateTime.Now;
            ViewBag.List = new List<int>()
            {
                1,
                2,
                3,
                4,
            };

            ViewData["a"] = "Hii from Chetu Inc";
            ViewData["a1"] = 1234;
            ViewData["a2"] = 12.2f;
            ViewData["a3"] = DateTime.Now;
            ViewData["List"] = new List<string>()
            {
                "Hii",
                "How",
                "Are",
                "You"
            };

            TempData["a"] = "Hii from Chetu Inc";
            TempData["a1"] = 1234;
            TempData["a2"] = 12.2f;
            TempData["a3"] = DateTime.Now;
            TempData["List"] = new List<string>()
            {
                "Hii",
                "How",
                "Are",
                "You"
            };

            return View();
        }

        public IActionResult Privacy()
        {

            HttpContext.Session.SetString("Name", "Aditya");
            //var res = HttpContext.Session.GetString("Name");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
