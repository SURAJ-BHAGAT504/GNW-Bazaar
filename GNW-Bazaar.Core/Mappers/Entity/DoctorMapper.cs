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
            HealthCareCategoryId = input.HealthCareCategoryId,
            Qualification = input.Qualification,
            AboutDoctor = input.AboutDoctor,
            Experience = input.Experience,
            Phonenumber = input.Phonenumber,
            WhatsAppNumber = input.WhatsAppNumber,
            Email = input.Email,
            Address = input.Address,
            Location = input.Location,
            IsActive = input.IsActive,
            CreatedOn = input.CreatedOn,
            UpdatedOn = input.UpdatedOn,
        };
    }
}
