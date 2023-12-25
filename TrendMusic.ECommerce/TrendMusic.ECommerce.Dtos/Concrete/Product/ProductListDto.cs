using TrendMusic.ECommerce.Core.Dtos.Abstract;

namespace TrendMusic.ECommerce.Dtos.Concrete.Product
{
    public class ProductListDto : IDto
    {
        public string ProductImageUrl { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductDemoPath { get; set; }
        public string ProductFullPath { get; set; }
        public int AppUserId { get; set; }
        public int Id { get; set; }
        public bool IsActive { get; set; } // ilgili alan aktif pasiflik bilgisi
        public DateTime CreatedDate { get; set; } = DateTime.Now; // Eğer bir kayıt yeni oluşturulacaksa o zaman ilgili alan işaretlendir.
        public DateTime UpdatedDate { get; set; }
    }
}
