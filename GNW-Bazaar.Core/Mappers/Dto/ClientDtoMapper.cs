using GNW_Bazaar.Core.Interface;
using GNW_Bazzar.Dto;
using GNW_Bazzar.Entity;

namespace GNW_Bazaar.Core.Mappers.Dto
{
    public class ClientDtoMapper : IMapper<Client, ClientDto>
    {
        public ClientDto Map(Client input) => new()
        {
            Id = input.Id,
            ClientName = input.ClientName,
            SubCategoryMasterIds = input.subCategoryMasters.Select(x => x.Id).ToList() ?? new List<long>(),
            Highlights = input.Highlights,
            PhoneNumber = input.PhoneNumber,
            WhatsAppNumber = input.WhatsAppNumber,
            Address = input.Address,
            Location = input.Location,
            ClientImagePath = input.ClientImage,
            EndDate = input.EndDate,
            IsActive = input.IsActive,
            CreatedOn = input.CreatedOn,
            UpdatedOn = input.UpdatedOn,
        };
    }
}
