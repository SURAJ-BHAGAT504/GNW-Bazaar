using System.ComponentModel.DataAnnotations;

namespace GNW_Bazzar.Entity
{
    public class Otp : Base
    {
        [Required]
        public string OtpCode { get; set; } = default!;
        [Required]
        public long UserId { get; set; }
        [Required]
        public string Purpose { get; set; } = default!;
        [Required]
        public DateTime ExpiresOn { get; set; }
        [Required]
        public bool IsUsed { get; set; } = false;
        [Required]
        public bool IsVerified { get; set; } = false;
        [Required]
        public long Attempts { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public User User { get; set; } = default!;
    }
}
