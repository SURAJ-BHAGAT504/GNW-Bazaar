using GNW_Bazaar.Core.Interface;
using GNW_Bazzar.Dto;
using GNW_Bazzar.Entity;

namespace GNW_Bazaar.Core.Mappers.Entity
{
    public class RefreshTokenMapper : IMapper<RefreshTokenDto, RefreshToken>
    {
        public RefreshToken Map(RefreshTokenDto input) => new()
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
