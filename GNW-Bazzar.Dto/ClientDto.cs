using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace GNW_Bazzar.Dto
{
    public class ClientDto : BaseDto
    {
        [Required(ErrorMessage = "Please enter client name"), StringLength(50, ErrorMessage = "Name can`t exceed 50 chars")]
        public string ClientName { get; set; } = default!;
        [Required(ErrorMessage = "Please enter Highlights")]
        public string Highlights { get; set; } = default!;
        [Required(ErrorMessage = "Please Enter your phone number"), MaxLength(10, ErrorMessage = "Phone number can`t exceed 10 digits")]
        public string PhoneNumber { get; set; } = default!;
        [Required(ErrorMessage = "Please Enter your whatsapp number"), MaxLength(10, ErrorMessage = "Whatsapp number can`t exceed 10 digits")]
        public string WhatsAppNumber { get; set; } = default!;
        [Required(ErrorMessage = "Please enter your address"), StringLength(500, ErrorMessage = "Address can`t exceed 500 chars")]
        public string Address { get; set; } = default!;
        [Required(ErrorMessage = "Please enter location"), StringLength(1000, ErrorMessage = "Location can`t exceed 1000 chars")]
        public string Location { get; set; } = default!;
        public IFormFile? ClientImage { get; set; }
        [Required(ErrorMessage = "Please enter end date")]
        public DateTime EndDate { get; set; }
        public string? ClientImagePath { get; set; } = null;
        [Required]
        public bool IsActive { get; set; } = true;
        [Required]
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
