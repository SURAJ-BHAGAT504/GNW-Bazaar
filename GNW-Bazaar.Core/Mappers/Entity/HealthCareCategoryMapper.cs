using GNW_Bazaar.Core.Interface;
using GNW_Bazzar.Dto;
using GNW_Bazzar.Entity;

namespace GNW_Bazaar.Core.Mappers.Entity
{
    public class HealthCareCategoryMapper : IMapper<HealthCareCategoryDto, HealthCareCategory>
    {
        public HealthCareCategory Map(HealthCareCategoryDto input) => new()
        {
            Id = input.Id,
            Category = input.Category,
            CreatedOn = input.CreatedOn,
            UpdatedOn = input.UpdatedOn,
        };
    }
}
