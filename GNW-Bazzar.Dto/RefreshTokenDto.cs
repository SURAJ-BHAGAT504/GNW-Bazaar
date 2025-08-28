using System.ComponentModel.DataAnnotations;

namespace GNW_Bazzar.Dto
{
    public class RefreshTokenDto : BaseDto
    {
        [Required]
        public string UserId { get; set; } = default!;
        [Required]
        public string Token { get; set; } = default!;
        [Required]
        public DateTime CreationDate { get; set; }
        [Required]
        public DateTime ExpiryDate { get; set; }
    }
}
