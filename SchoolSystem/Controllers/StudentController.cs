using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolSystem.Core.Contracts.Student;
using SchoolSystem.Core.Models.Parent;
using SchoolSystem.Core.Models.Student;
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
            int studentId = await StudentId();
            var model = await studentService.Grades(studentId);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> SubjectstWithTeachers()
        {
            int studentId = await StudentId();
            var model = await studentService.Teachers(studentId);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> SeeParent()
        {
            int studentId = await StudentId();
            var model = await studentService.Parent(studentId);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> PrincipalsWithInfo()
        {
            var model = await studentService.Principals();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Classmates()
        {
            int classId = await ClassId();
            var model = await studentService.Classmates(classId);

            return View(model);
        }


        private async Task<int> StudentId()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var studentId = await studentService.StudentId(userId);

            return studentId;
        }

        private async Task<int> ClassId()
        {
            var studentId = await StudentId();
            var classId = await studentService.ClassId(studentId);

            return classId;
        }
    }
}
