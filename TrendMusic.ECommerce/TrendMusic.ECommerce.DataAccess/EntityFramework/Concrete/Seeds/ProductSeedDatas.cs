using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrendMusic.ECommerce.Entities.Concrete;

namespace TrendMusic.ECommerce.DataAccess.EntityFramework.Concrete.Seeds
{
    public class ProductSeedDatas : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product
            {


            });
        }
    }
}
