using Microsoft.AspNetCore.Mvc;

namespace BassRigCurator.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
