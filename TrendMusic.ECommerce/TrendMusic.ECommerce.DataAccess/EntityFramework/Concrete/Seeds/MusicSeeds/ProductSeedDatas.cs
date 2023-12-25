using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrendMusic.ECommerce.Entities.Concrete;
using static System.Net.WebRequestMethods;

namespace TrendMusic.ECommerce.DataAccess.EntityFramework.Concrete.Seeds
{
    public class ProductSeedDatas : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id = 1, ProductName = "BombaPlak", ProductDescription = "Ceza & Killa Hakan 2009 Efsane Albüm & Düet ", ProductDemoPath = "demopath1", ProductFullPath = "Fullpath1", AppUserId = 1, IsActive = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, ProductImageUrl= "https://upload.wikimedia.org/wikipedia/tr/7/7f/Bomba_Plak.jpg" },
                new Product { Id = 2, ProductName = "Massaka & Syndikat", ProductDescription = "Massaka Syndikat Album", ProductDemoPath = "demopath1", ProductFullPath = "Fullpath1", AppUserId = 1, IsActive = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now ,ProductImageUrl = "https://scontent.fist13-1.fna.fbcdn.net/v/t1.6435-9/45627140_10157205667499026_6559733147800436736_n.jpg?_nc_cat=101&ccb=1-7&_nc_sid=c2f564&_nc_ohc=ymRuS6Qp4-YAX8Nnj0n&_nc_ht=scontent.fist13-1.fna&oh=00_AfB-VpCKAUzOsD8v3YPh1DxJeroAmsM8FO5redNH3It59Q&oe=65B10756" },
                new Product { Id = 3, ProductName = "Sagopa Kajmer - Bla Bla", ProductDescription = "Kağıt Kesikleri ", ProductDemoPath = "demopath1", ProductFullPath = "Fullpath1", AppUserId = 1, IsActive = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, ProductImageUrl = "https://i.ytimg.com/vi/MPz_t5yvSGE/maxresdefault.jpg" },
                new Product { Id = 4, ProductName = "Defkhan 59 ", ProductDescription = "defkhan 59 Albüm", ProductDemoPath = "demopath1", ProductFullPath = "Fullpath1", AppUserId = 1, IsActive = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, ProductImageUrl = "https://i.scdn.co/image/ab67616d0000b273ae03d01bd0a03f28f1866593" },
                new Product { Id = 5, ProductName = "Sagopa Kajmer ", ProductDescription = "Ceza & Sagopa Neyim Varki Rapten Gayri ?  ", ProductDemoPath = "demopath1", ProductFullPath = "Fullpath1", AppUserId = 1, IsActive = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now , ProductImageUrl = "https://img-s1.onedio.com/id-5cb6fe1f4d1e71621e1d9a9c/rev-0/w-600/h-337/f-jpg/s-a82b6fe62bb77271306dcd2871379b57eb120bf8.jpg" },
                new Product { Id = 6, ProductName = "Fuchs & Huzur Nedarem", ProductDescription = "Fucs Huzur N'Darem ", ProductDemoPath = "demopath1", ProductFullPath = "Fullpath1", AppUserId = 1, IsActive = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, ProductImageUrl = "https://i.ytimg.com/vi/KIfSEYLQqGk/hqdefault.jpg" },
                new Product { Id = 7, ProductName = "Fuat Ergin & Suvariler ", ProductDescription = "Ceza & Killa Hakan 2009 Efsane Albüm & Düet ", ProductDemoPath = "demopath1", ProductFullPath = "Fullpath1", AppUserId = 1, IsActive = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now , ProductImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/78/Fuat_Ergin.jpg/330px-Fuat_Ergin.jpg" }

                );
        }
    }
}
