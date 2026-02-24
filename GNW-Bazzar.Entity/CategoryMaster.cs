using System.ComponentModel.DataAnnotations;

namespace GNW_Bazzar.Entity
{
    public class CategoryMaster : Base
    {
        [Required]
        public string CategoryName { get; set; } = default!;
        public string Description { get; set; } = default!;
        [Required]
        public bool IsActive { get; set; } = true;
        [Required]
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public ICollection<HealthCareCategory> HealthCareCategories { get; set; } = default!;
    }
}
