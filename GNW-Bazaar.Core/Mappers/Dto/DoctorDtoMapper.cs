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
            HealthCareSubCategoryId = input.HealthCareSubCategoryId,
            Qualification = input.Qualification,
            AboutDoctor = input.AboutDoctor,
            Experience = input.Experience,
            Phonenumber = input.Phonenumber,
            Email = input.Email,
            Address = input.Address,
            location = input.Location,
            IsActive = input.IsActive,
            CreatedOn = input.CreatedOn,
            UpdatedOn = input.UpdatedOn,
        };
    }
}
