using System.ComponentModel.DataAnnotations;

namespace GNW_Bazzar.Entity
{
    public class Doctor : Base
    {
        [Required]
        public string DoctorName { get; set; } = default!;
        [Required]
        public long HealthCareCategoryId { get; set; }
        [Required]
        public string Qualification { get; set; } = default!;
        [Required]
        public string AboutDoctor { get; set; } = default!;
        [Required]
        public long Experience { get; set; } = default!;
        [Required]
        public string Phonenumber { get; set; } = default!;
        [Required]
        public string WhatsAppNumber { get; set; } = default!;
        [Required, EmailAddress]
        public string Email { get; set; } = default!;
        [Required]
        public string Address { get; set; } = default!;
        [Required]
        public string Location { get; set; } = default!;
        public string DoctorImage { get; set; } = default!;
        public string ClinicImage { get; set; } = default!;
        [Required]
        public bool IsActive { get; set; } = true;
        [Required]
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public HealthCareCategory healthCareCategory { get; set; } = default!;
    }
}
