using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GNW_Bazzar.Dto
{
    public class SignUpDto : BaseDto
    {
        [Required(ErrorMessage = "Please enter your name"), StringLength(50, ErrorMessage = "Name can`t exceed 50 chars")]
        public string Name { get; set; } = default!;
        [Required(ErrorMessage = "Please enter uour email"), EmailAddress]
        public string Email { get; set; } = default!;
        [Required(ErrorMessage = "Please enter your password"), PasswordPropertyText]
        public string Password { get; set; } = default!;
    }
}
