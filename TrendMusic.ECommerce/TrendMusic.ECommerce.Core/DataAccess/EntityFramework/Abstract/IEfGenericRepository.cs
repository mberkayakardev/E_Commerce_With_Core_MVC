using System.Linq.Expressions;
using TrendMusic.ECommerce.Core.DataAccess.EntityFramework.ComplexTypes;
using TrendMusic.ECommerce.Core.Entities.Abstract;

namespace TrendMusic.ECommerce.Core.DataAccess.EntityFramework.Abstract
{
    public interface IEfGenericRepository<T> where T : class, IEntity, new() // Tüm entitylerimi işaretlemek maksatlı olarak belirtiyorum
    {
        Task CreateAsync(T Entity); 
        Task UpdateAsync(T Entity);
        Task DeleteAsync(T Entity);
        Task SoftDeleteAsync(T Entity);
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> where = null, bool AsNoTracking = true, Expression<Func<T, object>> OrderByProperty = null, OrderByEnum order = OrderByEnum.Descanding, params Expression<Func<T, object>>[] IncludeProperties); // ORder By Key ile birlikte yapılabilmesi açısından eklenmiş bir değerdir. 
        Task<T> GetAsync(Expression<Func<T, bool>> where = null, bool AsNoTracking = false, Expression<Func<T, object>> OrderBy = null, OrderByEnum order = OrderByEnum.Descanding, params Expression<Func<T, object>>[] IncludeProperties); // Order By bu etapta sıralamaya göre ilk değerin alınması istenirse diye eklenmiştir.
        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
        Task<int> CountAsync(Expression<Func<T, bool>> predicate = null);
        IQueryable<T> GetAsQueryable();

    }
}
