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
            return View();
        }

        [HttpPost]
        [Route("Results")]
        public IActionResult HandleSurveyForm(SurveyViewModel surveyViewModel)
        {
            Console.WriteLine("budget", surveyViewModel.BassBudget);

            List<Bass> basses = context.Basses.ToList();
            List<Amp> amps = context.Amps.ToList();
            List<Bass> curatedBassList = new List<Bass>();
            List<Amp> curatedAmpList = new List<Amp>();

            if (ModelState.IsValid)
            {

                foreach (Bass bass in basses)
                {
                    if(bass.Price < surveyViewModel.BassBudget)
                    {
                        curatedBassList.Add(bass);
                    }
                }
            }
            ViewBag.Basses = curatedBassList;
            
            return Redirect("results");
        }


    }
}
