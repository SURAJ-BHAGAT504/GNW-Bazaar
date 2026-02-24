using GNW_Bazaar.Core.Interface;
using GNW_Bazzar.Dto;
using GNW_Bazzar.Entity;

namespace GNW_Bazaar.Core.Mappers.Entity
{
    public class SponsorMapper : IMapper<SponsorDto, Sponsor>
    {
        public Sponsor Map(SponsorDto input) => new()
        {
            Id = input.Id,
            ClientName = input.ClientName,
            Description = input.Description,
            PhoneNumber = input.PhoneNumber,
            Email = input.Email,
            SponsorType = input.SponsorType,
            StartDate = input.StartDate,
            EndDate = input.EndDate,
            CreatedBy = input.CreatedBy,
            CreatedOn = input.CreatedOn,
            UpdatedOn = input.UpdatedOn,
        };
    }
}
