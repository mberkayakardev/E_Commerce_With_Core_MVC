using TrendMusic.ECommerce.Core.Entities.Abstract;

namespace TrendMusic.ECommerce.Entities.Concrete
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; } // Ürün Adı (Bir ürün playlist te olablir, single da olabilir.)
        public AppUser ProductOwner { get; set; } // 
        //public AppUser? AppUserId { get; set; }

    }
}
