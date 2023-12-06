
namespace AkarCommerce.MusicStore.Core.Entities.Abstract
{
    public class BaseEntity : IEntity
    {
        public int Id { get; set; }
        public bool IsActive { get; set; } // Safe delete Operations
        public DateTime CreatedDate { get; set; } // Creaded Date Log
        public DateTime ModifiedDate { get; set; } // Last Updated Date Logs

    }
}
