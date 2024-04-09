using Microsoft.EntityFrameworkCore;
using SchoolSystem.Core.Contracts.Student;
using SchoolSystem.Core.Models.Parent;
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

        public async Task<int> StudentId(string userId)
        {
            return (await repository
                .AllReadOnly<Infrastructure.Data.Models.Student>()
                .FirstAsync(s => s.UserId == userId)).Id;
        }

        public async Task<int> ClassId(int studentId)
        {
            return (await repository
                .AllReadOnly<Infrastructure.Data.Models.Student>()
                .FirstAsync(s => s.Id == studentId)).ClassId;
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


            var model = new SubjectsWithGradesFormModel()
            {
                StudentId = studentId,
                StudentName = student != null ? $"{student.FirstName} {student.LastName}" : string.Empty,
                SubjectName = subjects,
                Grade = grades
            };

            return model;
        }

        public async Task<SubjectsWithTeachersFormModel> Teachers(int studentId)
        {
            var subjects = await repository
                .All<Subject>()
                .Select(s => s.Name)
                .ToListAsync();


            var teachers = await repository
                .All<Teacher>()
                .Select(t => t.FullName)
                .ToListAsync();


            var model = new SubjectsWithTeachersFormModel()
            {
                SubjectName = subjects,
                TeacherName = teachers
            };

            return model;
        }

        public async Task<ParentViewModel> Parent(int studentId)
        {
            var student = await repository.GetByIdAsync<Infrastructure.Data.Models.Student>(studentId);

            string studentName = await repository
                .All<Infrastructure.Data.Models.Student>()
                .Where(s => s.Id == studentId)
                .Select(s => $"{s.FirstName} {s.LastName}")
                .FirstAsync();


            string parentName = await repository
                .All<Parent>()
                .Where(p => p.Id == studentId)
                .Select(p => p.FullName)
                .FirstAsync();


            var model = new ParentViewModel()
            {
                StudentName = studentName,
                ParentName = parentName
            };

            return model; 
        }

        public async Task<PrincipalInfoFormModel> Principals()
        {
            var fullNames = await repository
                .All<Principal>()
                .Select(p => p.FullName)
                .ToListAsync();

            var emails = await repository
                .All<Principal>()
                .Select(p => p.Email ?? string.Empty)
                .ToListAsync();

            var phoneNumbers = await repository
                .All<Principal>()
                .Select(p => p.PhoneNumber ?? string.Empty)
                .ToListAsync();

            var model = new PrincipalInfoFormModel()
            {
                FullName = fullNames,
                Email = emails,
                PhoneNumber = phoneNumbers
            };

            return model;
        }

        public async Task<ClassmatesFormModel> Classmates(int classId)
        {
            string className = await repository
                .All<Class>()
                .Where(c => c.Id == classId)
                .Select(c => c.Name)
                .FirstAsync();

            string teacherName = await repository
                .All<Class>()
                .Where(c => c.Id == classId)
                .Select(c => c.Teacher.FullName)
                .FirstAsync();

            var classmatesName = await repository
                .All<Infrastructure.Data.Models.Student>()
                .Where(s => s.ClassId == classId)
                .Select(s => $"{s.FirstName} {s.LastName}")
                .ToListAsync();

            var model = new ClassmatesFormModel()
            {
                ClassName = className,
                TeacherName = teacherName,
                ClassmatesName = classmatesName
            };

            return model;
        }
    }
}
