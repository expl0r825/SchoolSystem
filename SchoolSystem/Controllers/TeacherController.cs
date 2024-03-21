using Microsoft.AspNetCore.Mvc;

namespace SchoolSystem.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
