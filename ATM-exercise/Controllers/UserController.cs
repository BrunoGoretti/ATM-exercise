using ATM_exercise.Data;
using Microsoft.AspNetCore.Mvc;

namespace ATM_exercise.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _db;

        public UserController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        //[ValidateAntiForgeryToken]
        public IActionResult InsertMenu()
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("ClientMenu", "ATM");
            }
            ModelState.AddModelError("", "Invalid password or login");
            return View();
        }
    }
}
