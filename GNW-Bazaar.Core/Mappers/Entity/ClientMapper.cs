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
            Highlights = input.Highlights,
            PhoneNumber = input.PhoneNumber,
            WhatsAppNumber = input.WhatsAppNumber,
            Address = input.Address,
            Location = input.Location,
            ClientImage = input.ClientImagePath,
            EndDate = input.EndDate,
            IsActive = input.IsActive,
            CreatedOn = input.CreatedOn,
            UpdatedOn = input.UpdatedOn,
        };
    }
}
