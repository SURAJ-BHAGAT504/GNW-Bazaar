using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GNW_Bazzar.Entity
{
    public class User : Base
    {
        [Required]
        public string Name { get; set; } = default!;
        [Required, EmailAddress]
        public string Email { get; set; } = default!;
        [Required]
        public string PhoneNumber { get; set; } = default!;
        [Required, PasswordPropertyText]
        public string Password { get; set; } = default!;
        [Required]
        public string UserRole { get; set; } = default!;
        [Required]
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public RefreshToken RefreshToken { get; set; } = default!;
    }
}
