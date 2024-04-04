using System.ComponentModel.DataAnnotations;
using static SchoolSystem.Infrastructure.Constants.DataConstants;

namespace SchoolSystem.Models
{
    public class RegisterViewModel
    {
        [Required]
        [StringLength(UserNameMaxLengthr, MinimumLength = UserNameMinLength)]
        public string UserName { get; set; } = null!;

        [Required]
        [EmailAddress]
        [StringLength(EmailMaxLength, MinimumLength = EmailMinLength)]
        public string Email { get; set; } = null!;

        [Required]
        [StringLength(PasswordMaxLength, MinimumLength = PasswordMinLength)]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;

        [Compare(nameof(Password))]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; } = null!;
    }
}
