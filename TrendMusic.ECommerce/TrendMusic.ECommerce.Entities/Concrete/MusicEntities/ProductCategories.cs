using TrendMusic.ECommerce.Core.Entities.Abstract;

namespace TrendMusic.ECommerce.Entities.Concrete.MusicEntities
{
	public class ProductCategories : BaseEntity
	{
		public int ProductId { get; set; }
		public Product Product { get; set; }
		public int CategoryId { get; set; }
		public Category Category { get; set; }

	}
}
