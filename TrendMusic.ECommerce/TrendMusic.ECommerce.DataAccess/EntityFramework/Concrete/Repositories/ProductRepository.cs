using Microsoft.EntityFrameworkCore;
using TrendMusic.ECommerce.Core.DataAccess.EntityFramework.Concrete;
using TrendMusic.ECommerce.DataAccess.EntityFramework.Abstract;
using TrendMusic.ECommerce.DataAccess.EntityFramework.Concrete.Contexts;
using TrendMusic.ECommerce.Entities.Concrete;

namespace TrendMusic.ECommerce.DataAccess.EntityFramework.Concrete.Repositories
{
    public class ProductRepository : EfGenericRepository<Product>, IProductRepository
    {
        public ProductRepository(MyDbContext context) : base(context)
        {

        }

        public async Task<List<Product>> GetTop3PRoduct()
        {
            // Business 
            var result = await _Entities.Where(x => x.Id == 1).ToListAsync();
            return result;
        }
    }
}
