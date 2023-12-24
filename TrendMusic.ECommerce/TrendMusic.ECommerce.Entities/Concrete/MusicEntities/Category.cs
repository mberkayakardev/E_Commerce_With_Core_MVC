using TrendMusic.ECommerce.Core.Entities.Abstract;
using TrendMusic.ECommerce.Entities.Concrete.MusicEntities;

namespace TrendMusic.ECommerce.Entities.Concrete
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }

        #region NavigationProperty
        public List<ProductCategories> ProductCategories { get; set; }
        #endregion
    }
}
