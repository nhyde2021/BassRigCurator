using Microsoft.AspNetCore.Mvc;

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
