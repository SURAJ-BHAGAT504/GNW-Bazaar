using System.ComponentModel.DataAnnotations;

namespace GNW_Bazzar.Entity
{
    public class Client : Base
    {
        public string ClientName { get; set; } = default!;
        [Required]
        public string Highlights { get; set; } = default!;
        [Required]
        public string PhoneNumber { get; set; } = default!;
        [Required]
        public string WhatsAppNumber { get; set; } = default!;
        [Required]
        public string Address { get; set; } = default!;
        [Required]
        public string Location { get; set; } = default!;
        public string ClientImage { get; set; } = default!;
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public bool IsActive { get; set; } = true;
        [Required]
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public virtual ICollection<SubCategoryMaster> subCategoryMasters { get; set; } = new List<SubCategoryMaster>();
    }
}
