using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SchoolSystem.Controllers
{
    [Authorize(Roles = "Parent")]
    public class ParentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
