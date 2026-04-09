using GNW_Bazaar.Core.Interface;
using GNW_Bazzar.Dto;
using GNW_Bazzar.Entity;

namespace GNW_Bazaar.Core.Mappers.Dto
{
    public class SubCategoryMasterDtoMapper : IMapper<SubCategoryMaster, SubCategoryMasterDto>
    {
        public SubCategoryMasterDto Map(SubCategoryMaster input) => new()
        {
            Id = input.Id,
            CategoryName = input.CategoryName,
            CategoryMasterId = input.CategoryMasterId,
            CreatedOn = input.CreatedOn,
            UpdatedOn = input.UpdatedOn,
        };
    }
}
