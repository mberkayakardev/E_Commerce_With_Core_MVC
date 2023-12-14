using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace TrendMusic.ECommerce.DataAccess.EntityFramework.Concrete.Contexts
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> opt) : base (opt)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        #region Tables

        #endregion
    }
}
