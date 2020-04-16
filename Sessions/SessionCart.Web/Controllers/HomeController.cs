using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using SessionCart.Web.Models;

namespace SessionCart.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SaveName(string FirstName)
        {
            HttpContext.Session.SetString("YourName", FirstName);
            return RedirectToAction("Second");
        }
        public IActionResult Second()
        {
            string sessionName = HttpContext.Session.GetString("YourName");
            ViewData["ViewDataName"] = sessionName;
            return View();
        }
        public IActionResult Third()
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
