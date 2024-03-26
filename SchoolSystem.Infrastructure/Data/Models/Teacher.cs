using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static SchoolSystem.Infrastructure.Constants.DataConstants;

namespace SchoolSystem.Infrastructure.Data.Models
{
    [Comment("School Teacher")]
    public class Teacher
    {
        [Key]
        [Comment("Teacher Identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(TeacherNameMaxLength)]
        [Comment("Teachers Full Name")]
        public string FullName { get; set; } = string.Empty;

        [Required]
        [Comment("Is the teacher a class teacher")]
        public bool IsClassTeacher { get; set; }

        [MaxLength(TeacherEmailMaxLength)]
        [Comment("Teachers Email Address")]
        public string? Email { get; set; }

        [MaxLength(TeacherPhoneNumberMaxLength)]
        [Comment("Teachers Phone Number")]
        public string? PhoneNumber { get; set; }

        [Required]
        public string UserId { get; set; } = string.Empty;

        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;

        public IList<Student> Students { get; set; } = new List<Student>();
    }
}
