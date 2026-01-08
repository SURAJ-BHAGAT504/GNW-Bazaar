using System.ComponentModel.DataAnnotations;

namespace GNW_Bazzar.Entity
{
    public class Client : Base
    {
        public string ClientName { get; set; } = default!;
        [Required]
        public long CategoryMasterId { get; set; }
        [Required]
        public string ContactPerson { get; set; } = default!;
        [Required]
        public string PhoneNumber { get; set; } = default!;
        [EmailAddress, Required]
        public string Email { get; set; } = default!;
        [Required]
        public string Address { get; set; } = default!;
        [Required]
        public string Location { get; set; } = default!;
        public string ClientImage { get; set; } = default!;
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public CategoryMaster CategoryMaster { get; set; } = default!;
    }
}
