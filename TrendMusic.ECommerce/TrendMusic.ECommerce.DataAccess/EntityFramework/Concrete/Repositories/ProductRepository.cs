using Microsoft.EntityFrameworkCore;
using System;
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


        public async Task<List<Product>> GetProductsWithCategoryName(string CategoryName)
        {
            var context = _Context as MyDbContext;
            var query = from p in context.Products
                        join pc in context.ProductCategories on p.Id equals pc.ProductId
                        join c in context.Categories on pc.CategoryId equals c.Id
                        where c.CategoryName.Trim().ToUpper() == CategoryName.Trim().ToUpper()
                        where c.IsActive == true
                        select p;

            return await query.ToListAsync();


        }
    }
}
