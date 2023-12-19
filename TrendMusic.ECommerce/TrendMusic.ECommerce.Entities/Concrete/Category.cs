using TrendMusic.ECommerce.Core.Entities.Abstract;

namespace TrendMusic.ECommerce.Entities.Concrete
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }

        #region NavigationProperty
        public List<Product> Products { get; set; }
        #endregion
    }
}
