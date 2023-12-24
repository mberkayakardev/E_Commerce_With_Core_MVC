using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TrendMusic.ECommerce.Entities.Concrete;
using TrendMusic.ECommerce.Entities.Concrete.Identity;
using TrendMusic.ECommerce.Entities.Concrete.MusicEntities;

namespace TrendMusic.ECommerce.DataAccess.EntityFramework.Concrete.Contexts
{
	public class MyDbContext : IdentityDbContext<AppUser, AppRole, int, IdentityUserClaim<int>, IdentityUserRole<int>, IdentityUserLogin<int>, IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public MyDbContext(DbContextOptions<MyDbContext> opt) : base(opt)
        {

        }

        //public MyDbContext() 
        //{

        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("server=.; database=TrendMusic_PROD; integrated security=true; TrustServerCertificate=true;");
        //    base.OnConfiguring(optionsBuilder);

        //}
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
        }


        #region Tables
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategories> ProductCategories { get; set; }

        #endregion
    }
}
