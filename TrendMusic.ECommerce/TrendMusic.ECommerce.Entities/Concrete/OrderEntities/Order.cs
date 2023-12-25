using TrendMusic.ECommerce.Core.Entities.Abstract;
using TrendMusic.ECommerce.Entities.Concrete.Identity;

namespace TrendMusic.ECommerce.Entities.Concrete.OrderEntities
{
    public class Order : BaseEntity
    {
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public decimal TotalPrice { get; set; }

        
    }
}
