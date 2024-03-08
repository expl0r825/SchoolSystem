using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SchoolSystem.Infrastructure.Data.Models;
using System.Drawing;
using System.Reflection.Emit;

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
                .HasKey(sbg => new { sbg.StudentId, sbg.SubjectId });

            builder
                 .Entity<Student>()
                 .HasOne(s => s.Class)
                 .WithMany(c => c.Students)
                 .HasForeignKey(s => s.ClassId)
                 .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<Student>()
                .HasOne(s => s.ClassTeacher)
                .WithMany(c => c.Students)
                .HasForeignKey(s => s.ClassTeacherId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<StudentSubjectGrade>()
                .Property(s => s.Grade)
                .HasColumnType("decimal(18,2)");


            base.OnModelCreating(builder);
        }

    }
}
