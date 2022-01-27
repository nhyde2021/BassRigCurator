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
        List<Bass> curatedBassList = new List<Bass>();
        List<Amp> curatedAmpList = new List<Amp>();
        
        public IActionResult Index()
        {
            SurveyViewModel surveyViewModel = new SurveyViewModel();
            return View(surveyViewModel);
        }

        [HttpPost]
        [Route("Survey/Index")]
        public IActionResult HandleSurveyForm(SurveyViewModel surveyViewModel)
        {
            SurveyViewModel surveyAnswers = new SurveyViewModel
            {
                BassBudget = surveyViewModel.BassBudget,
                AmpBudget = surveyViewModel.AmpBudget,
                Volume = surveyViewModel.Volume,
                Genre = surveyViewModel.Genre
            };
            List<Bass> basses = context.Basses.ToList();
            List<Amp> amps = context.Amps.ToList();

            if (ModelState.IsValid)
            {

                foreach (Bass bass in basses)
                {
                    if(bass.Price < surveyAnswers.BassBudget)
                    {
                        if(bass.Genre == surveyAnswers.Genre)
                        {
                            curatedBassList.Add(bass);
                        }
                    }
                }
            }
            ViewBag.bassSelections = curatedBassList;
            
            return View("Results");
        }

        public IActionResult Results()
        {
            ViewBag.bassSelections = curatedBassList;
            ViewBag.ampSelections = curatedAmpList;
            return View();
        }
    }
}
