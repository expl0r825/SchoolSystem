using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolSystem.Core.Contracts.Student;
using SchoolSystem.Core.Models.Student;
using SchoolSystem.Core.Services.Student;
using System.Security.Claims;


namespace SchoolSystem.Controllers
{
    [Authorize(Roles = "Student")]
    public class StudentController : Controller
    {
        private readonly IStudentService studentService;

        public StudentController(IStudentService _studentService)
        {
            studentService = _studentService;
        }

        [HttpGet]
        public async Task<IActionResult> SubjectsWithGrades()
        {
            int id = await StudentId();

            var model = await studentService.Grades(id);


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


        private async Task<int> StudentId()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var student = await studentService.Students(userId);

            return student;
        }
    }
}
