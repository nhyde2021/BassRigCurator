using Microsoft.AspNetCore.Mvc;

namespace BassRigCurator.Controllers
{
    public class ResultsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
