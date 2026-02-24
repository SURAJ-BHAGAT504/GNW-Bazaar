using System.ComponentModel.DataAnnotations;

namespace GNW_Bazzar.Entity
{
    public class Sponsor : Base
    {
        [Required]
        public string ClientName { get; set; } = default!;
        [Required]
        public string Description { get; set; } = default!;
        [Required, Phone]
        public string PhoneNumber { get; set; } = default!;
        [Required, EmailAddress]
        public string Email { get; set; } = default!;
        public string SponsorFile { get; set; } = default!;
        [Required]
        public string SponsorType { get; set; } = default!;
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public bool IsActive { get; set; } = true;
        [Required]
        public string CreatedBy { get; set; } = default!;
        [Required]
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
