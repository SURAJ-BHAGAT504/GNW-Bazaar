using GNW_Bazaar.Core.Interface;
using GNW_Bazzar.Dto;
using GNW_Bazzar.Entity;

namespace GNW_Bazaar.Core.Mappers.Dto
{
    public class DoctorDtoMapper : IMapper<Doctor, DoctorDto>
    {
        public DoctorDto Map(Doctor input) => new()
        {
            Id = input.Id,
            DoctorName = input.DoctorName,
            HealthCareCategoryId = input.HealthCareCategoryId,
            Qualification = input.Qualification,
            AboutDoctor = input.AboutDoctor,
            Experience = input.Experience,
            Phonenumber = input.Phonenumber,
            WhatsAppNumber = input.WhatsAppNumber,
            Email = input.Email,
            Address = input.Address,
            Location = input.Location,
            DoctorImagePath = input.DoctorImage,
            ClinicImagePath = input.ClinicImage,
            IsActive = input.IsActive,
            CreatedOn = input.CreatedOn,
            UpdatedOn = input.UpdatedOn,
        };
    }
}
