using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Capstone.Web.Models;
using Capstone.Web.DAL;
using Microsoft.AspNetCore.Http;

namespace Capstone.Web.Controllers
{
    public class HomeController : Controller
    {
        private IParkDao ParkDao;
        private IWeatherDao WeatherDao;
        public HomeController(IParkDao parkDao, IWeatherDao weatherDao)
        {
            ParkDao = parkDao;
            WeatherDao = weatherDao;
        }
        public IActionResult Index()
        {
            IList<Park> parks = ParkDao.GetAllParks();
            return View(parks);
        }
        public IActionResult SaveTempChoice(string tempScale, string parkCode)
        {
            ParkWeather parkWeather = new ParkWeather();
            parkWeather.TempScale = tempScale;
            HttpContext.Session.SetString("TempScale", tempScale);
            return RedirectToAction("Detail", new{ parkCode });
        }
        private string GetTempChoice()
        {
            string tempChoice = HttpContext.Session.GetString("TempScale");
            return tempChoice;           
        }
        public IActionResult Detail(string parkCode)
        {            
            ParkWeather parkWeather = new ParkWeather();
            parkWeather.Park = ParkDao.GetSelectedPark(parkCode);
            parkWeather.Weathers = WeatherDao.GetAllWeathers(parkCode);
            parkWeather.TempScale = GetTempChoice();
            
            return View(parkWeather);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
