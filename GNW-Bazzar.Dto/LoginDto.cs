using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GNW_Bazzar.Dto
{
    public class LoginDto
    {
        [Required(ErrorMessage ="Please enter your email address"), EmailAddress]
        public string Email { get; set; } = default!;
        [Required(ErrorMessage ="Please enter your password"), PasswordPropertyText]
        public string Password { get; set; } = default!;
    }
}
