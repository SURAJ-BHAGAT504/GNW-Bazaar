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
            HealthCareSubCategoryId = input.HealthCareSubCategoryId,
            Qualification = input.Qualification,
            AboutDoctor = input.AboutDoctor,
            Experience = input.Experience,
            Phonenumber = input.Phonenumber,
            Email = input.Email,
            Address = input.Address,
            Location = input.location,
            IsActive = input.IsActive,
            CreatedOn = input.CreatedOn,
            UpdatedOn = input.UpdatedOn,
        };
    }
}
