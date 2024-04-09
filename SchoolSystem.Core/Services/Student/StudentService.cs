using Microsoft.EntityFrameworkCore;
using SchoolSystem.Core.Contracts.Student;
using SchoolSystem.Core.Models.Student;
using SchoolSystem.Infrastructure.Data.Common;
using SchoolSystem.Infrastructure.Data.Models;

namespace SchoolSystem.Core.Services.Student
{
    public class StudentService : IStudentService
    {
        private readonly IRepository repository;

        public StudentService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<int> Students(string userId)
        {
            return (await repository.AllReadOnly<Infrastructure.Data.Models.Student>()
                .FirstAsync(s => s.UserId == userId)).Id;
        }

        public async Task<SubjectsWithGradesFormModel> Grades(int studentId)
        {
            var student = await repository.GetByIdAsync<Infrastructure.Data.Models.Student>(studentId);

            var subjects = await repository
                .All<StudentSubjectGrade>()
                .Where(ssg => ssg.StudentId == studentId)
                .Join(repository.All<Subject>(),
                      ssg => ssg.SubjectId,
                      s => s.Id,
                      (ssg, s) => s.Name)
                .ToListAsync();

            var grades = await repository
                .All<StudentSubjectGrade>()
                .Where(ssg => ssg.StudentId == studentId)
                .Select(ssg => ssg.Grade)
                .ToListAsync();

            var finish = new SubjectsWithGradesFormModel()
            {
                StudentId = studentId,
                StudentName = student != null ? $"{student.FirstName} {student.LastName}" : string.Empty,
                SubjectName = subjects,
                Grade = grades
            };

            return finish;
        }
    }
}
