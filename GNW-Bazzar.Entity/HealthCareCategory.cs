using System.ComponentModel.DataAnnotations;

namespace GNW_Bazzar.Entity
{
    public class HealthCareCategory : Base
    {
        [Required, StringLength(50)]
        public string Category { get; set; } = default!;
        [Required]
        public long CategoryMasterId { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public CategoryMaster CategoryMaster { get; set; } = default!;
    }
}
