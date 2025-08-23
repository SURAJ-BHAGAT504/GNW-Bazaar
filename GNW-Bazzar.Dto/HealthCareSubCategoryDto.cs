using System.ComponentModel.DataAnnotations;

namespace GNW_Bazzar.Dto
{
    public class HealthCareSubCategoryDto : BaseDto
    {
        [Required(ErrorMessage = "Please enter SubCategory"), StringLength(50, ErrorMessage = "SubCategory can`t exceed 50 chars")]
        public string SubCategory { get; set; } = default!;
        [Required(ErrorMessage ="Please enter Category")]
        public long HealthCareCategoryId { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
