using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrendMusic.ECommerce.Entities.Concrete;

namespace TrendMusic.ECommerce.DataAccess.EntityFramework.Concrete.Seeds
{
    public class CategorySeedDatas : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { Id = 1, CategoryName = "Blues", CreatedDate = DateTime.Now, IsActive = true, UpdatedDate = DateTime.Now },
                new Category { Id = 2, CategoryName = "Klasik Müzik", CreatedDate = DateTime.Now, IsActive = true, UpdatedDate = DateTime.Now },
                new Category { Id = 3, CategoryName = "Halk Müzikleri", CreatedDate = DateTime.Now, IsActive = true, UpdatedDate = DateTime.Now },
                new Category { Id = 4, CategoryName = "Elektronik Müzik", CreatedDate = DateTime.Now, IsActive = true, UpdatedDate = DateTime.Now },
                new Category { Id = 5, CategoryName = "Hip - Hop", CreatedDate = DateTime.Now, IsActive = true, UpdatedDate = DateTime.Now },
                new Category { Id = 6, CategoryName = "Cazz ", CreatedDate = DateTime.Now, IsActive = true, UpdatedDate = DateTime.Now },
                new Category { Id = 7, CategoryName = "Pop ", CreatedDate = DateTime.Now, IsActive = true, UpdatedDate = DateTime.Now },
                new Category { Id = 8, CategoryName = "Rock", CreatedDate = DateTime.Now, IsActive = true, UpdatedDate = DateTime.Now },
                new Category { Id = 9, CategoryName = "Çocuk Müzikleri ", CreatedDate = DateTime.Now, IsActive = true, UpdatedDate = DateTime.Now },
                new Category { Id = 10, CategoryName = "Dini Müzik Türleri", CreatedDate = DateTime.Now, IsActive = true, UpdatedDate = DateTime.Now },
                new Category { Id = 11, CategoryName = "Enstrümantal", CreatedDate = DateTime.Now, IsActive = true, UpdatedDate = DateTime.Now }
                );
        }
    }
}
