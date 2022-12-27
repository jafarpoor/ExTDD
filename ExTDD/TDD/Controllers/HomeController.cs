using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TDD.Models;
using TDD.Services;

namespace TDD.Controllers
{
    public class HomeController : Controller
    {
        Sum sum;
        public HomeController()
        {
            sum = new Sum();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Sum(string Numbers)
        {
            return Json(sum.Execute(Numbers));
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
