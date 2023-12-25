using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrendMusic.ECommerce.Entities.Concrete.MusicEntities;

namespace TrendMusic.ECommerce.DataAccess.EntityFramework.Concrete.Seeds.MusicSeeds
{
    public class ProductCategoriesSeeds : IEntityTypeConfiguration<ProductCategories>
    {
        public void Configure(EntityTypeBuilder<ProductCategories> builder)
        {
            builder.HasData(
                new ProductCategories { Id = 1, CategoryId = 1, ProductId = 1, IsActive = true, UpdatedDate = DateTime.Now, CreatedDate = DateTime.Now},
                new ProductCategories { Id = 2, CategoryId = 1, ProductId = 2, IsActive = true, UpdatedDate = DateTime.Now, CreatedDate = DateTime.Now },
                new ProductCategories { Id = 3, CategoryId = 2, ProductId = 3, IsActive = true, UpdatedDate = DateTime.Now, CreatedDate = DateTime.Now },
                new ProductCategories { Id = 4, CategoryId = 3, ProductId = 4, IsActive = true, UpdatedDate = DateTime.Now, CreatedDate = DateTime.Now },
                new ProductCategories { Id = 5, CategoryId = 4, ProductId = 5, IsActive = true, UpdatedDate = DateTime.Now, CreatedDate = DateTime.Now },
                new ProductCategories { Id = 6, CategoryId = 5, ProductId = 6, IsActive = true, UpdatedDate = DateTime.Now, CreatedDate = DateTime.Now }
                );
        }
    }
}
