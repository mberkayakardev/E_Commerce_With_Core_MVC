namespace TrendMusic.ECommerce.Core.Entities.Abstract
{
    public abstract class BaseEntity : IEntity
    {
        public int Id { get; set; }  
        public string? ConcurrencyStamp { get; set; } // Ef tarafında işaretlenecektir
        public bool IsActive { get; set; } // ilgili alan aktif pasiflik bilgisi
        public DateTime CreatedDate { get; set; } = DateTime.Now; // Eğer bir kayıt yeni oluşturulacaksa o zaman ilgili alan işaretlendir.
        public DateTime UpdatedDate { get; set; }

    }
}
