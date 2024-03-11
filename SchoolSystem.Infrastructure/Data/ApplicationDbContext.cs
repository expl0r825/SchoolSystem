using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SchoolSystem.Infrastructure.Data.Models;
using SchoolSystem.Infrastructure.Data.SeedDb;

namespace SchoolSystem.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Principal> Principals { get; set; } = null!;
        public DbSet<Student> Students { get; set; } = null!;
        public DbSet<Parent> Parents { get; set; } = null!;
        public DbSet<Subject> Subjects { get; set; } = null!;
        public DbSet<Teacher> Teachers { get; set; } = null!;
        public DbSet<Class> Classes { get; set; } = null!;
        public DbSet<StudentSubjectGrade> StudentsSubjectsGrades { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<StudentSubjectGrade>()
                .HasKey(ssg => new { ssg.StudentId, ssg.SubjectId });

            builder
                .Entity<StudentSubjectGrade>()
                .Property(s => s.Grade)
                .HasColumnType("decimal(18,2)");


            builder.ApplyConfiguration(new ClassConfiguration());
            builder.ApplyConfiguration(new ParentConfiguration());
            builder.ApplyConfiguration(new PrincipalConfiguration());
            builder.ApplyConfiguration(new StudentConfiguration());
            builder.ApplyConfiguration(new StudentSubjectGradeConfiguration());
            builder.ApplyConfiguration(new SubjectConfiguration());
            builder.ApplyConfiguration(new TeacherConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());


            base.OnModelCreating(builder);
        }
    }
}
