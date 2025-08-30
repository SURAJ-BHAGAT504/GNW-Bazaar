using System.ComponentModel.DataAnnotations;

namespace GNW_Bazzar.Entity
{
    public class RefreshToken : Base
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

        public User User { get; set; } = default!;
    }
}
