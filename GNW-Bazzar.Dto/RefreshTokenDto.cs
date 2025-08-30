using System.ComponentModel.DataAnnotations;

namespace GNW_Bazzar.Dto
{
    public class RefreshTokenDto : BaseDto
    {
        [Required]
        public long UserId { get; set; } = default!;
        [Required]
        public string Token { get; set; } = default!;
        [Required]
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        [Required]
        public DateTime ExpiryDate { get; set; }
    }
}
