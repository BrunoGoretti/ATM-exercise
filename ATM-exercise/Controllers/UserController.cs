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
    }
}
