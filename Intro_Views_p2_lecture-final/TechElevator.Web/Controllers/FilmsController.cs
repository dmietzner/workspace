using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechElevator.Web.DAL;
using TechElevator.Web.Models;

namespace TechElevator.Web.Controllers
{
    public class FilmsController : Controller
    {
        public IActionResult Index()
        {
            // Instantiated the dao object
            IStarWarsDAO dao = new MockStarWarsDAO();
            // Asked the DAO to get me all the films and assign to the variable movies
            IList<Film> movies = dao.GetFilms();
            // Pass the variable movies into the razor engine to bind to the view
            return View(movies);

        }
        // parameter name must match what's in startup.cs
        public IActionResult Detail(string movie_id)
        {
            IStarWarsDAO dao = new MockStarWarsDAO();
            if(!String.IsNullOrEmpty(movie_id))
            {
                Film movie = dao.GetFilm(movie_id);
                if(movie == null)
                {
                    return NotFound();
                }
                return View(movie);
            } else
            {
                return NotFound();
            }
        }
    }
}