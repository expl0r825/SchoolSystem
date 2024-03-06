using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static SchoolSystem.Infrastructure.Constants.DataConstants;

namespace SchoolSystem.Infrastructure.Data.Models
{
    [Comment("School Principal")]
    public class Principal
    {
        [Key]
        [Comment("Principal Identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(PrincipalNameMaxLength)]
        [Comment("Principals Full Name")]
        public string FullName { get; set; } = string.Empty;

        [MaxLength(PrincipalEmailMaxLength)]
        [Comment("Principals Email Address")]
        public string? Email { get; set; }

        [MaxLength(PrincipalPhoneNumberMaxLength)]
        [Comment("Principals Phone Number")]
        public string? PhoneNumber { get; set; }

        [Required]
        public string UserId { get; set; } = string.Empty;

        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;
    }
}
