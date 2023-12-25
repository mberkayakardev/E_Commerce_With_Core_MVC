using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TrendMusic.ECommerce.Entities.Concrete;
using TrendMusic.ECommerce.Entities.Concrete.Identity;
using TrendMusic.ECommerce.Entities.Concrete.IdentityEntities;
using TrendMusic.ECommerce.Entities.Concrete.MusicEntities;
using TrendMusic.ECommerce.Entities.Concrete.OrderEntities;

namespace TrendMusic.ECommerce.DataAccess.EntityFramework.Concrete.Contexts
{
	public class MyDbContext : IdentityDbContext<AppUser, AppRole, int, IdentityUserClaim<int>, IdentityUserRole<int>, IdentityUserLogin<int>, IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public MyDbContext(DbContextOptions<MyDbContext> opt) : base(opt)
        {

        }
    
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            foreach (var item in ChangeTracker.Entries())
            {
                if (this.Entry(item).State == EntityState.Modified)
                {
                }


            }
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }


        #region Tables
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategories> ProductCategories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<TransactionHistory> TransactionsHistory { get; set; }

        #endregion
    }
}
