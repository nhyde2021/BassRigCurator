using BassRigCurator.Data;
using BassRigCurator.Models;
using BassRigCurator.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BassRigCurator.Controllers
{
    public class SurveyController : Controller
    {
        private ApplicationDbContext context;

        public SurveyController(ApplicationDbContext dbContext)
        {
            context = dbContext;
        }
        public IActionResult Index()
        {
            SurveyViewModel surveyViewModel = new SurveyViewModel();
            return View(surveyViewModel);
        }

        [HttpPost]
        public IActionResult HandleSurveyForm(SurveyViewModel surveyViewModel)
        {
            SurveyViewModel surveyAnswers = new SurveyViewModel
            {
                BassBudget = surveyViewModel.BassBudget,
                AmpBudget = surveyViewModel.AmpBudget,
                Volume = surveyViewModel.Volume,
                Genre = surveyViewModel.Genre
            };
            Console.WriteLine("budget", surveyAnswers.BassBudget);

            List<Bass> basses = context.Basses.ToList();
            List<Amp> amps = context.Amps.ToList();
            List<Bass> curatedBassList = new List<Bass>();
            List<Amp> curatedAmpList = new List<Amp>();

            if (ModelState.IsValid)
            {

                foreach (Bass bass in basses)
                {
                    if(bass.Price < surveyAnswers.BassBudget)
                    {
                        curatedBassList.Add(bass);
                    }
                }
            }
            ViewBag.Basses = curatedBassList;
            
            return Redirect("/results");
        }


    }
}
