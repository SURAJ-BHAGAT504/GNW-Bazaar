using System.ComponentModel.DataAnnotations;

namespace GNW_Bazzar.Entity
{
    public class HealthCareSubCategory : Base
    {
        [Required, StringLength(50)]
        public string SubCategory { get; set; } = default!;
        [Required]
        public long HealthCareCategoryId { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public HealthCareCategory HealthCareCategory { get; set; } = default!;
    }
}
