using GNW_Bazaar.Core.Interface;
using GNW_Bazzar.Dto;
using GNW_Bazzar.Entity;

namespace GNW_Bazaar.Core.Mappers.Dto
{
    public class CategoryMasterDtoMapper : IMapper<CategoryMaster, CategoryMasterDto>
    {
        public CategoryMasterDto Map(CategoryMaster input) => new()
        {
            Id = input.Id,
            CategoryName = input.CategoryName,
            Description = input.Description,
            IsActive = input.IsActive,
            CreatedOn = input.CreatedOn,
            UpdatedOn = input.UpdatedOn
        };
    }
}
