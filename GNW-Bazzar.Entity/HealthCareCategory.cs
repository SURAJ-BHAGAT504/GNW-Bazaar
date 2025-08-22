using System.ComponentModel.DataAnnotations;

namespace GNW_Bazzar.Entity
{
    public class HealthCareCategory : Base
    {
        [Required, StringLength(50)]
        public string Category { get; set; } = default!;
        [Required]
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedBy { get; set; }

        public ICollection<HealthCareSubCategory> HealthCareSubCategories { get; set; } = default!;
    }
}
