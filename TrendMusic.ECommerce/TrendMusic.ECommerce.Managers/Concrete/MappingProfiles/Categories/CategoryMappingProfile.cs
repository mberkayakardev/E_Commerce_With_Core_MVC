using AutoMapper;
using TrendMusic.ECommerce.Dtos.Concrete.Category;
using TrendMusic.ECommerce.Entities.Concrete;

namespace TrendMusic.ECommerce.Managers.Concrete.MappingProfiles.Categories
{
    public class CategoryMappingProfile : Profile
    {
        public CategoryMappingProfile()
        {
            CreateMap<Category, CategoryListDto>().ReverseMap();
        }
    }
}
