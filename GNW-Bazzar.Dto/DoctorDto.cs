using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace GNW_Bazzar.Dto
{
    public class DoctorDto : BaseDto
    {
        [Required(ErrorMessage = "Please enter doctor name"), StringLength(50, ErrorMessage = "Name can`t exceed 50 chars")]
        public string DoctorName { get; set; } = default!;
        [Required(ErrorMessage = "Please enter healthcare subcategory")]
        public long HealthCareSubCategoryId { get; set; }
        [Required(ErrorMessage = "Please enter qualification")]
        public string Qualification { get; set; } = default!;
        [Required(ErrorMessage = "Please enter about doctor")]
        public string AboutDoctor { get; set; } = default!;
        [Required(ErrorMessage = "Please enter experience")]
        public long Experience { get; set; } = default!;
        [Required(ErrorMessage = "Please Enter your phone number"), MaxLength(10, ErrorMessage = "Phone number can`t exceed 10 digits")]
        public string Phonenumber { get; set; } = default!;
        [Required(ErrorMessage = "Please enter uour email"), EmailAddress]
        public string Email { get; set; } = default!;
        [Required(ErrorMessage = "Please enter your address"), StringLength(500, ErrorMessage = "Address can`t exceed 500 chars")]
        public string Address { get; set; } = default!;
        [Required(ErrorMessage = "Please enter location"), StringLength(1000, ErrorMessage = "Location can`t exceed 1000 chars")]
        public string location { get; set; } = default!;
        public IFormFile? DoctorImage { get; set; }
        public IFormFile? ClinicImage { get; set; }
        [Required]
        public bool IsActive { get; set; } = true;
        [Required]
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
