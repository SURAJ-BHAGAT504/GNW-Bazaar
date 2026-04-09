using GNW_Bazaar.Core.Interface;
using GNW_Bazzar.Dto;
using GNW_Bazzar.Entity;

namespace GNW_Bazaar.Core.Mappers.Entity
{
    public class SubCategoryMasterMapper : IMapper<SubCategoryMasterDto, SubCategoryMaster>
    {
        public SubCategoryMaster Map(SubCategoryMasterDto input) => new()
        {
            Id = input.Id,
            CategoryName = input.CategoryName,
            CategoryMasterId = input.CategoryMasterId,
            CreatedOn = input.CreatedOn,
            UpdatedOn = input.UpdatedOn,
        };
    }
}
