using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TrendMusic.ECommerce.Core.Entities.Abstract;

namespace TrendMusic.ECommerce.Entities.Concrete
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
    }
}
