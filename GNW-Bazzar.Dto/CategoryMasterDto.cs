using System.ComponentModel.DataAnnotations;

namespace GNW_Bazzar.Dto
{
    public class CategoryMasterDto : BaseDto
    {
        [Required(ErrorMessage = "Please enter category"), StringLength(150, ErrorMessage = "Category can`t exceed 150 chars")]
        public string CategoryName { get; set; } = default!;
        public string Description { get; set; } = default!;
        [Required]
        public bool IsActive { get; set; } = true;
        [Required]
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
