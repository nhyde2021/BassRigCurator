using BassRigCurator.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BassRigCurator.Controllers
{
    public class SurveyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


    }
}
