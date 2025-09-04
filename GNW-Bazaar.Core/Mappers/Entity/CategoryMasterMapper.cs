using GNW_Bazaar.Core.Interface;
using GNW_Bazzar.Dto;
using GNW_Bazzar.Entity;

namespace GNW_Bazaar.Core.Mappers.Entity
{
    public class CategoryMasterMapper : IMapper<CategoryMasterDto, CategoryMaster>
    {
        public CategoryMaster Map(CategoryMasterDto input) => new()
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
