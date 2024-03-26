using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static SchoolSystem.Infrastructure.Constants.DataConstants;

namespace SchoolSystem.Infrastructure.Data.Models
{
    [Comment("School Student")]
    public class Student
    {
        [Key]
        [Comment("Student Identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(StudentNameMaxLength)]
        [Comment("Students First Name")]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MaxLength(StudentNameMaxLength)]
        [Comment("Students Last Name")]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [Comment("Students Class Identifier")]
        public int ClassId { get; set; }

        [ForeignKey(nameof(ClassId))]
        public Class Class { get; set; } = null!;

        [Required]
        [Comment("Students Teacher Identifier")]
        public int ClassTeacherId { get; set; }

        [ForeignKey(nameof(ClassTeacherId))]
        public Teacher ClassTeacher { get; set; } = null!;

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        [Comment("Students Average Score")]

        public decimal AverageScore { get; set; }

        [Required]
        public string UserId { get; set; } = string.Empty;

        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;

        public IList<Subject> Subjects { get; set; } = new List<Subject>();
    }
}
