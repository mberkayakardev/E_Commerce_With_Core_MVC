using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrendMusic.ECommerce.Entities.Concrete.Identity;

namespace TrendMusic.ECommerce.DataAccess.EntityFramework.Concrete.Seeds.İdentitySeeds
{
    public class AppUserSeeds : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            var hasher = new PasswordHasher<AppUser>();


            builder.HasData(new AppUser
            {
                Id = 1,
                UserName = "Neşet Ertaş",
                NormalizedUserName = "NesetErtas",
                PasswordHash = hasher.HashPassword(null, "Qwerasdf0147"),
                Email = "NesetErtas@gmail.com",
                TwoFactorEnabled = false,
                PhoneNumber = "+90 555 44 33 22",
                PhoneNumberConfirmed = false,
                EmailConfirmed = false,

            });

            builder.HasData(new AppUser
            {
                Id = 2,
                UserName = "Berkay Akar",
                NormalizedUserName = "BerkayAkar",
                PasswordHash = hasher.HashPassword(null, "Qwerasdf0147"),
                Email = "berkayakar@gmail.com",
                TwoFactorEnabled = false,
                PhoneNumber = "+90 534 541 34 10",
                PhoneNumberConfirmed = false,
                EmailConfirmed = false,

            });
        }
    }
}
