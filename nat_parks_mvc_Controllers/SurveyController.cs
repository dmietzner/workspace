using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Capstone.Web.DAL;
using Capstone.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Capstone.Web.Controllers
{
    public class SurveyController : Controller
    {
        private ISurveyDao SurveyDao;
        public SurveyController(ISurveyDao surveyDao)
        {
            SurveyDao = surveyDao;
        }
        [HttpGet]        
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(SurveyViewModel input)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index", "Survey");

            }
            SurveyViewModel survey = SurveyDao.AddSurvey(input);
                IList<SurveyResult> surveyResults = SurveyDao.GetAllSurveys();
                return View("Confirmation", surveyResults);
            
        
        }
    }
}