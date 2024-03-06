using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static SchoolSystem.Infrastructure.Constants.DataConstants;

namespace SchoolSystem.Infrastructure.Data.Models
{
    [Comment("School Parent")]
    public class Parent
    {
        [Key]
        [Comment("Parent Identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(ParentNameMaxLength)]
        [Comment("Parents Full Name")]
        public string FullName { get; set; } = string.Empty;

        [Required]
        [Comment("Parents Child Identifier")]
        public int ChildId { get; set; }

        public Student Child { get; set; } = null!;

        [Required]
        public string UserId { get; set; } = string.Empty;

        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;
    }
}
