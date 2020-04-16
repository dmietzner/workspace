using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SessionExercise.Web.Extensions;
using SessionExercise.Web.Models;

namespace SessionExercise.Web.Controllers
{
    public class FavoriteThingsController : Controller
    {
        private const string FavoriteThingsKey = "FAVORITE_THINGS";

        [HttpGet]
        public IActionResult Page1()
        {
            HttpContext.Session.Set<FavoriteThings>(FavoriteThingsKey, new FavoriteThings());
            return View(nameof(Page1));
        }

        [HttpPost]
        public IActionResult Page1(string favoriteColor)
        {
            FavoriteThings favoriteThings = GetFavoriteThings();
            favoriteThings.FavoriteColor = favoriteColor;
            SaveFavoriteThings(favoriteThings);
            return RedirectToAction(nameof(Page2));
        }

        [HttpGet]
        public IActionResult Page2()
        {
            return View(nameof(Page2));
        }

        [HttpPost]
        public IActionResult Page2(string favoriteFood)
        {
            FavoriteThings favoriteThings = GetFavoriteThings();
            favoriteThings.FavoriteFood = favoriteFood;
            SaveFavoriteThings(favoriteThings);
            return RedirectToAction(nameof(Page3));
        }

        [HttpGet]
        public IActionResult Page3()
        {
            return View(nameof(Page3));
        }

        [HttpPost]
        public IActionResult Page3(string favoriteSeason)
        {
            FavoriteThings favoriteThings = GetFavoriteThings();
            favoriteThings.FavoriteSeason = favoriteSeason;
            SaveFavoriteThings(favoriteThings);
            return RedirectToAction(nameof(Summary));
        }

        [HttpGet]
        public IActionResult Summary()
        {
            FavoriteThings favoriteThings = GetFavoriteThings();
            return View(nameof(Summary), favoriteThings);
        }

        private FavoriteThings GetFavoriteThings()
        {
            return HttpContext.Session.Get<FavoriteThings>(FavoriteThingsKey);
        }

        private void SaveFavoriteThings(FavoriteThings favoriteThings)
        {
            HttpContext.Session.Set<FavoriteThings>(FavoriteThingsKey, favoriteThings);
        }
    }
}
