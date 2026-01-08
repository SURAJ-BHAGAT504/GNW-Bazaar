using GNW_Bazaar.Core.Interface;
using GNW_Bazzar.Dto;
using GNW_Bazzar.Entity;

namespace GNW_Bazaar.Core.Mappers.Entity
{
    public class ClientMapper : IMapper<ClientDto, Client>
    {
        public Client Map(ClientDto input) => new()
        {
            Id = input.Id,
            ClientName = input.ClientName,
            CategoryMasterId = input.CategoryMasterId,
            ContactPerson = input.ContactPerson,
            PhoneNumber = input.PhoneNumber,
            Email = input.Email,
            Address = input.Address,
            Location = input.Location,
            IsActive = input.IsActive,
            CreatedOn = input.CreatedOn,
            UpdatedOn = input.UpdatedOn,
        };
    }
}
