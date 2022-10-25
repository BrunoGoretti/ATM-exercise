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

        [HttpGet]
        //[ValidateAntiForgeryToken]
        public IActionResult InsertMenu()
        {
            if (ModelState.IsValid)
            {
                return View();
            }


            ModelState.AddModelError("", "Invalid password or login");

            return NotFound();
        }
    }
}
