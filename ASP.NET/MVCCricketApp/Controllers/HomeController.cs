using Microsoft.AspNetCore.Mvc;
using MVCCricketApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCricketApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() {
            return View();
            //return Content("Hello Welocome to Indian Cricket Team");
        }

        public IActionResult About(string name,int num=5) {
            ViewData["Message"] = "Hii " + name;
            ViewData["Num"] = num;

            return View();
        }

        public IActionResult Privacy() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
