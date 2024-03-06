using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace SchoolSystem.Infrastructure.Data.Models
{
    public class StudentSubjectGrade
    {
        [Required]
        [Comment("Student Identifier")]
        public int StudentId { get; set; }

        [Comment("Subject Identifier")]
        [Required]
        public int SubjectId { get; set; }

        [Comment("Students Grade")]
        [Required]
        public decimal Grade { get; set; }
    }
}
