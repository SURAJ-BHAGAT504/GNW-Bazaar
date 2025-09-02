using System.ComponentModel.DataAnnotations;

namespace GNW_Bazzar.Dto
{
    public class OtpDto : BaseDto
    {
        [Required, MaxLength(4, ErrorMessage = "Otp can`t exceed 4 digits")]
        public string OtpCode { get; set; } = default!;
        [Required]
        public long UserId { get; set; }
        [Required]
        public string Purpose { get; set; } = default!;
        [Required]
        public DateTime ExpiresOn { get; set; }
        [Required]
        public bool IsUsed { get; set; }
        [Required]
        public long Attempts { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
