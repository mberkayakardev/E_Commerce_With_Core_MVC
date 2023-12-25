using TrendMusic.ECommerce.Core.Entities.Abstract;
using TrendMusic.ECommerce.Entities.Concrete.Identity;
using TrendMusic.ECommerce.Entities.Concrete.MusicEntities;

namespace TrendMusic.ECommerce.Entities.Concrete
{
    public class Product : BaseEntity
    {
        public string ProductImageUrl { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductDemoPath { get; set; }
        public string ProductFullPath { get; set; }
        public List<ProductCategories> ProductCategories { get; set; }
        public AppUser ProductOwner { get; set; }
        public int AppUserId { get; set; }

    }
}
