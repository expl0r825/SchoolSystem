using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolSystem.Infrastructure.Data.Models
{
    [Comment("School Subject")]
    public class Subject
    {
        [Key]
        [Comment("Subject Identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Subject Name")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Comment("Subject Teacher")]
        public int TeacherId { get; set; }

        [ForeignKey(nameof(TeacherId))]
        public Teacher Teacher { get; set; } = null!;

        public IList<Student> Students { get; set; } = new List<Student>();
    }
}
