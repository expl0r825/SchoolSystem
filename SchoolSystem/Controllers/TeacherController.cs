using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolSystem.Core.Models.Teacher;

namespace SchoolSystem.Controllers
{
    [Authorize(Roles = "Teacher")]
    public class TeacherController : Controller
    {
        [HttpGet]
        public IActionResult StudentsWithGrades()
        {
            var model = new StudentsWithGradesFornModel();

            return View(model);
        }

        [HttpGet]
        public IActionResult StudentsWithParents()
        {
            var model = new StudentsWithParentsFormModel();

            return View(model);
        }

        [HttpGet]
        public IActionResult ClassesWithGrades()
        {
            var model = new ClassesWithGradesFormModel();

            return View(model);
        }

        [HttpGet]
        public IActionResult AllTeachers()
        {
            var model = new AllTeachersQueryModel();

            return View(model);
        }
    }
}
