using SchoolSystem.Core.Models.Parent;
using SchoolSystem.Core.Models.Student;

namespace SchoolSystem.Core.Contracts.Student
{
    public interface IStudentService
    {
        Task<SubjectsWithGradesFormModel> Grades(int studentId);

        Task<int> StudentId(string userId);

        Task<int> ClassId(int studentId);

        Task<SubjectsWithTeachersFormModel> Teachers(int studentId);

        Task<ParentViewModel> Parent(int studentId);

        Task<PrincipalInfoFormModel> Principals();

        Task<ClassmatesFormModel> Classmates(int classId);
    }
}
