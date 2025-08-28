using System.ComponentModel.DataAnnotations;

namespace GNW_Bazzar.Entity
{
    public class RefreshToken : Base
    {
        [Required]
        public string UserId { get; set; } = default!;
        [Required]
        public string Token { get; set; }= default!;
        [Required]
        public DateTime CreationDate { get; set; }
        [Required]
        public DateTime ExpiryDate { get; set; }

        public int MyProperty { get; set; }
    }
}
