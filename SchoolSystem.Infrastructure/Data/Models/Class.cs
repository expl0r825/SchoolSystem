using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static SchoolSystem.Infrastructure.Constants.DataConstants;

namespace SchoolSystem.Infrastructure.Data.Models
{
    [Comment("School Class")]
    public class Class
    {
        [Key]
        [Comment("Class Identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(ClassNameMaxLength)]
        [Comment("Class Name")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        [Comment("Class Average Score")]
        public decimal AverageScore { get; set; }

        [Required]
        [Comment("Class Teacher Identifier")]
        public int TeacherId { get; set; }

        [ForeignKey(nameof(TeacherId))]
        public Teacher Teacher { get; set; } = null!;

        public IList<Student> Students { get; set; } = new List<Student>();
    }
}
