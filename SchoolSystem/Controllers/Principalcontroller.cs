using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SchoolSystem.Controllers
{
    [Authorize(Roles="Principal")]
    public class Principalcontroller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
