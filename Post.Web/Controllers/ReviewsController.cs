using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Post.Web.DAL;
using Post.Web.Models;

namespace Post.Web.Controllers
{
    public class ReviewsController : Controller
    {
        private IReviewDAO reviewDAO;

        public ReviewsController(IReviewDAO dao)
        {
            reviewDAO = dao;
        }

        [HttpGet]
        public IActionResult AddReview()
        {
            return View();
        }
       [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult AddReview(Review review)

        {
            try
            {
                reviewDAO.SaveReview(review); 
            }
            catch (Exception)
            {
                TempData["Error"] = "Something went wrong, try again!";
                return RedirectToAction("Index","Home");
            }
            TempData["UserName"] = review.UserName;
            return RedirectToAction("Confirmation", "Reviews", new { UserName = review.UserName, Rating = review.Rating, Title = review.Title, Text = review.Text });
        }
        public IActionResult Confirmation()
        {
            return View();
        }
    }
}
