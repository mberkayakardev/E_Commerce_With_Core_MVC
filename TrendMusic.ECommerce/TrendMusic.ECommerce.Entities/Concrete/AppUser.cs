using Microsoft.AspNetCore.Identity;

namespace TrendMusic.ECommerce.Entities.Concrete
{
    public class AppUser :IdentityUser<int>
    {
        public string Username { get; set; }

    }
}
