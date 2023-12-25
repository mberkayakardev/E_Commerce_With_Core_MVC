using Microsoft.AspNetCore.Identity;
using TrendMusic.ECommerce.Entities.Concrete.IdentityEntities;
using TrendMusic.ECommerce.Entities.Concrete.OrderEntities;

namespace TrendMusic.ECommerce.Entities.Concrete.Identity
{
    public class AppUser : IdentityUser<int>
    {
        public List<Order> Orders { get; set; }
        public List<TransactionHistory> Transactions { get; set; }
        public decimal Amount { get; set; }  // Kullanıcıların Para değeri 
    }
}
