using GNW_Bazaar.Core.Interface;
using GNW_Bazzar.Dto;
using GNW_Bazzar.Entity;

namespace GNW_Bazaar.Core.Mappers.Dto
{
    public class RefreshTokenDtoMapper : IMapper<RefreshToken, RefreshTokenDto>
    {
        public RefreshTokenDto Map(RefreshToken input) => new()
        {
            Id = input.Id,
            UserId = input.UserId,
            Token = input.Token,
            CreatedOn = input.CreatedOn,
            UpdatedOn = input.UpdatedOn,
            ExpiryDate = input.ExpiryDate,
        };
    }
}
