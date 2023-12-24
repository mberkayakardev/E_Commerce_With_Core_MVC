using TrendMusic.ECommerce.Core.DataAccess.EntityFramework.Abstract;
using TrendMusic.ECommerce.Entities.Concrete;

namespace TrendMusic.ECommerce.DataAccess.EntityFramework.Abstract
{
    public interface IProductRepository : IEfGenericRepository<Product>
    {
        Task<List<Product>> GetProductsWithCategoryName(string CategoryName);

    }
}
