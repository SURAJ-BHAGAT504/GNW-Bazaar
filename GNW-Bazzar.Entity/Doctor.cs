using System.ComponentModel.DataAnnotations;

namespace GNW_Bazzar.Entity
{
    public class Doctor : Base
    {
        [Required]
        public string DoctorName { get; set; } = default!;
        [Required]
        public string AboutDoctor { get; set; } = default!;
        [Required]
        public string Phonenumber { get; set; } = default!;
        [Required]
        public string WhatsAppNumber { get; set; } = default!;
        [Required]
        public string Address { get; set; } = default!;
        [Required]
        public string Location { get; set; } = default!;
        public string DoctorImage { get; set; } = default!;
        public string ClinicImage { get; set; } = default!;
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public bool IsActive { get; set; } = true;
        [Required]
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public virtual ICollection<HealthCareCategory> healthCareCategory { get; set; } = new List<HealthCareCategory>();
    }
}
