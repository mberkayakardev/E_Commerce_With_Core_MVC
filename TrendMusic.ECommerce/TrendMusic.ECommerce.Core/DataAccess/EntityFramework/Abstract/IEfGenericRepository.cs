using System.Linq.Expressions;
using TrendMusic.ECommerce.Core.DataAccess.EntityFramework.ComplexTypes;
using TrendMusic.ECommerce.Core.Entities.Abstract;
using TrendMusic.ECommerce.Core.Utilities.Pagination.ComplexTypes;

namespace TrendMusic.ECommerce.Core.DataAccess.EntityFramework.Abstract
{
    public interface IEfGenericRepository<T> where T : class, IEntity, new() // Tüm entitylerimi işaretlemek maksatlı olarak belirtiyorum
    {
        Task<T> CreateAsync(T Entity);  // Oluşturduğum Entitylerimi Dönmem gerekecektir. IEEE
        Task UpdateAsync(T Entity);
        Task DeleteAsync(T Entity);
        Task SoftDeleteAsync(T Entity);
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> where = null, bool AsNoTracking = true, Expression<Func<T, object>> OrderByProperty = null, OrderByEnum order = OrderByEnum.Descanding, params Expression<Func<T, object>>[] IncludeProperties); // ORder By Key ile birlikte yapılabilmesi açısından eklenmiş bir değerdir. 
        Task<List<T>> GetAllAsyncWithListExpression(IList<Expression<Func<T, bool>>> where = null, bool AsNoTracking = true, Expression<Func<T, object>> OrderByProperty = null, OrderByEnum order = OrderByEnum.Descanding, params Expression<Func<T, object>>[] IncludeProperties); // ORder By Key ile birlikte yapılabilmesi açısından eklenmiş bir değerdir. 
        Task<PagedList<T>> GetAllWithPagingAsync(RequestParameters parameters, Expression<Func<T, bool>> where = null, bool AsNoTracking = true, Expression<Func<T, object>> OrderByProperty = null, OrderByEnum order = OrderByEnum.Descanding, params Expression<Func<T, object>>[] IncludeProperties); // Paging ile veri gelmesini sağlar 
        Task<PagedList<T>> GetAllWithPagingAsync(RequestParameters parameters, IList<Expression<Func<T, bool>>> where = null, bool AsNoTracking = true, Expression<Func<T, object>> OrderByProperty = null, OrderByEnum order = OrderByEnum.Descanding, params Expression<Func<T, object>>[] IncludeProperties); // Paging ile veri gelmesini sağlar 
        Task<T> GetAsync(Expression<Func<T, bool>> where = null, bool AsNoTracking = false, Expression<Func<T, object>> OrderBy = null, OrderByEnum order = OrderByEnum.Descanding, params Expression<Func<T, object>>[] IncludeProperties); // Order By bu etapta sıralamaya göre ilk değerin alınması istenirse diye eklenmiştir.
        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
        Task<int> CountAsync(Expression<Func<T, bool>> predicate = null);
        IQueryable<T> GetAsQueryable();

    }
}
