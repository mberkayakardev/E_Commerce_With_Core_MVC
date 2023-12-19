namespace TrendMusic.ECommerce.Dtos.Concrete.Category
{
    public class CategoryListDto
    {
        public int Id { get; set; }
        public string ConcurrencyStamp { get; set; } // Ef tarafında işaretlenecektir
        public bool IsActive { get; set; } // ilgili alan aktif pasiflik bilgisi
        public string CategoryName { get; set; }

    }
}
