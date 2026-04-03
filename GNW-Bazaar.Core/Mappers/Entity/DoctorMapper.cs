using GNW_Bazaar.Core.Interface;
using GNW_Bazzar.Dto;
using GNW_Bazzar.Entity;

namespace GNW_Bazaar.Core.Mappers.Entity
{
    public class DoctorMapper : IMapper<DoctorDto, Doctor>
    {
        public Doctor Map(DoctorDto input) => new()
        {
            Id = input.Id,
            DoctorName = input.DoctorName,
            healthCareCategory = new List<HealthCareCategory>(),
            AboutDoctor = input.AboutDoctor,
            Phonenumber = input.Phonenumber,
            WhatsAppNumber = input.WhatsAppNumber,
            Address = input.Address,
            Location = input.Location,
            DoctorImage = input.DoctorImagePath ?? string.Empty,
            ClinicImage = input.ClinicImagePath ?? string.Empty,
            EndDate = input.EndDate,
            IsActive = input.IsActive,
            CreatedOn = input.CreatedOn,
            UpdatedOn = input.UpdatedOn,
        };
    }
}
