using AutoMapper;
using TrendMusic.ECommerce.Dtos.Concrete.Product;
using TrendMusic.ECommerce.Entities.Concrete;

namespace TrendMusic.ECommerce.Managers.Concrete.MappingProfiles.Products
{
    public class ProductMappingProfile : Profile
    {
        public ProductMappingProfile()
        {
            CreateMap<Product, ProductListDto>().ReverseMap();
        }
    }
}
