using Microsoft.AspNetCore.Mvc;

namespace SchoolSystem.Controllers
{
    public class Principalcontroller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
