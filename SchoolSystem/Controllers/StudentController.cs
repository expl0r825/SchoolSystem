using Microsoft.AspNetCore.Mvc;

namespace SchoolSystem.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
