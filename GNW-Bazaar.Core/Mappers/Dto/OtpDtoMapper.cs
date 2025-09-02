using GNW_Bazaar.Core.Interface;
using GNW_Bazzar.Dto;
using GNW_Bazzar.Entity;

namespace GNW_Bazaar.Core.Mappers.Dto
{
    public class OtpDtoMapper : IMapper<Otp, OtpDto>
    {
        public OtpDto Map(Otp input) => new()
        {
            Id = input.Id,
            OtpCode = input.OtpCode,
            UserId = input.UserId,
            Purpose = input.Purpose,
            ExpiresOn = input.ExpiresOn,
            IsUsed = input.IsUsed,
            Attempts = input.Attempts,
            CreatedOn = input.CreatedOn,
            UpdatedOn = input.UpdatedOn
        };
    }
}
