using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolSystem.Core.Models.Parent;
using SchoolSystem.Core.Models.Student;

namespace SchoolSystem.Controllers
{
    [Authorize(Roles = "Parent")]
    public class ParentController : Controller
    {
        [HttpGet]
        public IActionResult ChildsGrades()
        {
            var model = new SubjectsWithGradesFormModel();

            return View(model);
        }

        [HttpGet]
        public IActionResult ParentsFromClass()
        {
            var model = new ParentsFromClassFormModel();

            return View(model);
        }

        [HttpGet]
        public IActionResult AllTeachers()
        {
            var model = new SubjectsWithTeachersFormModel();

            return View(model);
        }
    }
}
