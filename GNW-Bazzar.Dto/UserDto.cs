using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GNW_Bazzar.Dto
{
    public class UserDto : BaseDto
    {
        [Required(ErrorMessage = "Please enter your name"), StringLength(50, ErrorMessage = "Name can`t exceed 50 chars")]
        public string Name { get; set; } = default!;
        [Required(ErrorMessage = "Please enter your email"), EmailAddress]
        public string Email { get; set; } = default!;
        [Required(ErrorMessage = "Please Enter your phone number"), MaxLength(10, ErrorMessage = "Phone number can`t exceed 10 digits")]
        public string PhoneNumber { get; set; } = default!;
        [Required(ErrorMessage = "Please enter your password"), PasswordPropertyText]
        public string Password { get; set; } = default!;
        [Required(ErrorMessage = "Please enter your user role")]
        public string UserRole { get; set; } = default!;
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public DateTime LastLogin { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
