using TrendMusic.ECommerce.Core.Entities.Abstract;
using TrendMusic.ECommerce.Entities.Concrete.Identity;

namespace TrendMusic.ECommerce.Entities.Concrete.IdentityEntities
{
    public class TransactionHistory : BaseEntity
    {
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }    


        public decimal TransactionAmount { get; set; }
        public string TransactionDescription { get; set; }
    }
}
