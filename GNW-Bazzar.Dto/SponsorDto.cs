using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace GNW_Bazzar.Dto
{
    public class SponsorDto : BaseDto
    {
        [Required(ErrorMessage = "Please enter client name"), StringLength(50, ErrorMessage = "Client name can`t exceed 50 chars")]
        public string ClientName { get; set; } = default!;
        [Required(ErrorMessage = "Please enter sponsor description")]
        public string Description { get; set; } = default!;
        [Required(ErrorMessage = "Please Enter client phone number"), MaxLength(10, ErrorMessage = "Phone number can`t exceed 10 digits")]
        public string PhoneNumber { get; set; } = default!;
        [Required(ErrorMessage = "Please enter client email"), EmailAddress]
        public string Email { get; set; } = default!;
        [Required]
        public IFormFile? SponsorFile { get; set; } = default!;
        public string? SponsorFilePath { get; set; } = null;
        [Required]
        public string SponsorType { get; set; } = default!;
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public bool IsActive { get; set; } = true;
        [Required]
        public string CreatedBy { get; set; } = default!;
        [Required]
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
