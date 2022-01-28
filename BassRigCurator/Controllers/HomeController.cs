using BassRigCurator.Data;
using BassRigCurator.Models;
using BassRigCurator.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BassRigCurator.Controllers
{
    public class HomeController : Controller
    {

        private ApplicationDbContext context;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext dbContext)
        {
            _logger = logger;
            context = dbContext;
        }

        public IActionResult Index()
        {
            return View();
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

        public IActionResult AddBass()
        {
            AddBassViewModel addBassViewModel = new AddBassViewModel();

            return View(addBassViewModel);
        }

        [HttpPost]
        public IActionResult HandleAddBassForm(AddBassViewModel addBassViewModel)
        {
            if (ModelState.IsValid)
            {
                Bass newBass = new Bass
                {
                    Brand = addBassViewModel.Brand,
                    Model = addBassViewModel.Model,
                    Price = addBassViewModel.Price,
                    Description = addBassViewModel.Description,
                    Genre = addBassViewModel.Genre
                };
                context.Basses.Add(newBass);
                context.SaveChanges();

                return Redirect("AddBass");
            }
            return View("AddBass");

        }


        public IActionResult AddAmp()
        {
            AddAmpViewModel addAmpViewModel = new AddAmpViewModel();

            return View(addAmpViewModel);
        }

        [HttpPost]
        public IActionResult HandleAddAmpForm(AddAmpViewModel addAmpViewModel)
        {
            if (ModelState.IsValid)
            {
                Amp newAmp = new Amp
                {
                    Brand = addAmpViewModel.Brand,
                    Model = addAmpViewModel.Model,
                    Price = addAmpViewModel.Price,
                    Description = addAmpViewModel.Description,
                    Volume = addAmpViewModel.Volume
                };
                context.Amps.Add(newAmp);
                context.SaveChanges();

                return Redirect("AddAmp");
            }
            return View("AddAmp");

        }
    }
}
