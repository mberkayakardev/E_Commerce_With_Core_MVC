using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace AkarCommerce.MusicStore.DataAccess.Concrete.EntityFramework.Contexts
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base (options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        #region Entities

        #endregion
    }
}
