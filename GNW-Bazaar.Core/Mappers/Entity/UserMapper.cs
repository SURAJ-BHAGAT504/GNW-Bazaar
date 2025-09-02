using GNW_Bazaar.Core.Interface;
using GNW_Bazzar.Dto;
using GNW_Bazzar.Entity;

namespace GNW_Bazaar.Core.Mappers.Entity
{
    public class UserMapper : IMapper<UserDto, User>
    {
        public User Map(UserDto input) => new()
        {
            Id = input.Id,
            Name = input.Name,
            Email = input.Email,
            PhoneNumber = input.PhoneNumber,
            Password = input.Password,
            UserRole = input.UserRole,
            IsActive = input.IsActive,
            LastLogin = input.LastLogin,
            CreatedOn = input.CreatedOn,
            UpdatedOn = input.UpdatedOn,
        };
    }
}
