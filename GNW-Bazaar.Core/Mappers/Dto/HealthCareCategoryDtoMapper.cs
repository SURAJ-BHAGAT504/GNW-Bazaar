using GNW_Bazaar.Core.Interface;
using GNW_Bazzar.Dto;
using GNW_Bazzar.Entity;

namespace GNW_Bazaar.Core.Mappers.Dto
{
    public class HealthCareCategoryDtoMapper : IMapper<HealthCareCategory, HealthCareCategoryDto>
    {
        public HealthCareCategoryDto Map(HealthCareCategory input) => new()
        {
            Id = input.Id,
            Category = input.Category,
            CategoryMasterId = input.CategoryMasterId,
            CreatedOn = input.CreatedOn,
            UpdatedOn = input.UpdatedOn,
        };
    }
}
