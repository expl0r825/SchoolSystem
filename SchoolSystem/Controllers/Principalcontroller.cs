using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolSystem.Core.Models.Student;
using SchoolSystem.Core.Models.Teacher;

namespace SchoolSystem.Controllers
{
    [Authorize(Roles = "Principal")]
    public class PrincipalController : Controller
    {
        [HttpGet]
        public IActionResult AddTeacher()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTeacher(TeacherFormModel model)
        {
            return RedirectToAction(nameof(AllTeachers));
        }

        [HttpGet]
        public IActionResult TeacherDetails(int id)
        {
            var model = new TeacherDetailsViewModel();

            return View(model);
        }

        [HttpGet]
        public IActionResult RemoveTeacher(int id)
        {
            var model = new TeacherDetailsViewModel();

            return View(model);
        }

        [HttpPost]
        public IActionResult RemoveTeacher(TeacherDetailsViewModel teacher)
        {
            return RedirectToAction(nameof(AllTeachers));
        }

        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddStudent(StudentFormModel model)
        {
            return RedirectToAction(nameof(AllStudents));
        }

        [HttpGet]
        public IActionResult StudentDetails(int id)
        {
            var model = new StudentDetailsViewModel();

            return View(model);
        }

        [HttpGet]
        public IActionResult RemoveStudent(int id)
        {
            var model = new StudentDetailsViewModel();

            return View(model);
        }

        [HttpPost]
        public IActionResult RemoveStudent(StudentDetailsViewModel teacher)
        {
            return RedirectToAction(nameof(AllTeachers));
        }

        





        [HttpGet]
        public IActionResult AllTeachers()
        {
            var model = new AllTeachersQueryModel();

            return View(model);
        }

        [HttpGet]
        public IActionResult AllStudents()
        {
            var model = new AllStudentsQueryModel();

            return View(model);
        }
    }
}
