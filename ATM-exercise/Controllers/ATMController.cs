using Microsoft.AspNetCore.Mvc;

namespace ATM_exercise.Controllers
{
    public class ATMController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ClientMenu()
        {
            return View();
        }

        [HttpGet]
        public IActionResult OperatorMenu()
        {
            return View();
        }
    }
}
