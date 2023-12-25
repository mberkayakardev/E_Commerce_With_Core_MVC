using TrendMusic.ECommerce.Core.Utilities.Pagination.ComplexTypes;

namespace TrendMusic.ECommerce.Managers.Concrete.ComplexTypes.Product
{
    public class ProductSearchModel : RequestParameters
    {
        public int? CategoryId { get; set; }
        public string? ProductName { get; set; }
        public DateTime? CikisYili { get; set; } // Çikiş zamanı yıl veya ay bazlı bir şekilde filrtelenebilmesi için
        public int? AuthorId { get; set; } // ilgili kişinin id si 
    }
}
