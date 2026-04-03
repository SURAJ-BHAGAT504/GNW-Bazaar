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
            HealthCareCategoryIds = input.healthCareCategory?.Select(x=> x.Id).ToList() ?? new List<long>(),
            AboutDoctor = input.AboutDoctor,
            Phonenumber = input.Phonenumber,
            WhatsAppNumber = input.WhatsAppNumber,
            Address = input.Address,
            Location = input.Location,
            DoctorImagePath = input.DoctorImage,
            ClinicImagePath = input.ClinicImage,
            EndDate = input.EndDate,
            IsActive = input.IsActive,
            CreatedOn = input.CreatedOn,
            UpdatedOn = input.UpdatedOn,
        };
    }
}
