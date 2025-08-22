using System.ComponentModel.DataAnnotations;

namespace GNW_Bazzar.Dto
{
    public class HealthCareCategoryDto : BaseDto
    {
        [Required(ErrorMessage = "Please enter Category"), StringLength(50, ErrorMessage = "Category can`t exceed 50 chars")]
        public string Category { get; set; } = default!;
        [Required]
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedBy { get; set; }
    }
}
