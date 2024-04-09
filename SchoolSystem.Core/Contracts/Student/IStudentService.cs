using SchoolSystem.Core.Models.Student;
using SchoolSystem.Core.Models.Teacher;

namespace SchoolSystem.Core.Contracts.Student
{
    public interface IStudentService
    {
        Task<SubjectsWithGradesFormModel> Grades(int studentId);

        Task<int> Students(string userId);
    }
}
