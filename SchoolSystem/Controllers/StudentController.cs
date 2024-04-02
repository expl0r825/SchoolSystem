using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolSystem.Core.Models.Student;

namespace SchoolSystem.Controllers
{
    [Authorize(Roles = "Student")]
    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult SubjectsWithGrades()
        {
            var model = new SubjectsWithGradesFormModel();

            return View(model);
        }

        [HttpGet]
        public IActionResult SubjectstWithTeachers()
        {
            var model = new SubjectsWithTeachersFormModel();

            return View(model);
        }

        [HttpGet]
        public IActionResult SeeParent()
        {
            ViewData["Parent"] = "";

            return View();
        }

        [HttpGet]
        public IActionResult PrincipalsWithInfo()
        {
            var model = new PrincipalInfoFormModel();

            return View(model);
        }

        [HttpGet]
        public IActionResult Classmates()
        {
            var model = new ClassmatesFormModel();

            return View(model);
        }


        private int StudentId()
        {
            return 0;
        }
    }
}
