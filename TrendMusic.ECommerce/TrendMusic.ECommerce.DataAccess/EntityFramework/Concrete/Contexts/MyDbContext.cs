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

        //public MyDbContext()
        //{
            
        //}


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("server=.; database=TrendMusic_DEV; integrated security=true; TrustServerCertificate=true;");
        //}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
        }



        #region Tables
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Music> Musics { get; set; }

        #endregion
    }
}
