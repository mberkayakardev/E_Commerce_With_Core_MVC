using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TrendMusic.ECommerce.Entities.Concrete;

namespace TrendMusic.ECommerce.DataAccess.EntityFramework.Concrete.Contexts
{
    public class MyDbContext : IdentityDbContext<AppUser, IdentityRole<int>, int, IdentityUserClaim<int>, IdentityUserRole<int>, IdentityUserLogin<int>, IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public MyDbContext(DbContextOptions<MyDbContext> opt) : base(opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }



        #region Tables
        public DbSet<Product> Products { get; set; }    
        #endregion
    }
}
