using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TrendMusic.ECommerce.Core.DataAccess.EntityFramework.Abstract;
using TrendMusic.ECommerce.Core.DataAccess.EntityFramework.ComplexTypes;
using TrendMusic.ECommerce.Core.Entities.Abstract;

namespace TrendMusic.ECommerce.Core.DataAccess.EntityFramework.Concrete
{
    public class EfGenericRepository<T> : IEfGenericRepository<T> where T : class, IEntity, new()
    {
        private readonly DbContext _Context;
        private readonly DbSet<T> _Entities;

        public EfGenericRepository(DbContext context)
        {
            _Context = context;
            _Entities = _Context.Set<T>();
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> predicate)
        {
            var result = await _Entities.AnyAsync(predicate);
            return result;
        }

        public async Task<int> CountAsync(Expression<Func<T, bool>> predicate = null)
        {
            return (predicate == null) ? await _Entities.CountAsync() : await _Entities.CountAsync(predicate);
        }

        public async Task CreateAsync(T Entity)
        {
            await _Entities.AddAsync(Entity);
        }

        public async Task DeleteAsync(T Entity) // varsayılanda Delete Asenkron bir method değildir. Bunu Task kullanarak Asenkronik bir hale getirmiş bulunmaktayım.
        {
            await Task.Run(() =>
            {
                _Entities.Remove(Entity);
            });
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> where = null, bool AsNoTracking = true, Expression<Func<T, object>> OrderByProperty = null, OrderByEnum order = OrderByEnum.Descanding, params Expression<Func<T, object>>[] IncludeProperties)
        {
            IQueryable<T> query = _Entities;

            if (IncludeProperties != null)

                foreach (var item in IncludeProperties)
                    query = query.Include(item);

            if (where != null)
                query = query.Where(where);

            if (OrderByProperty != null)
            {
                if (order == OrderByEnum.Ascending)
                    query = query.OrderBy(OrderByProperty);
                else
                    query = query.OrderByDescending(OrderByProperty);
            }

            if (AsNoTracking == true)
                query = query.AsNoTracking();

            return await query.ToListAsync();
        }

        public IQueryable<T> GetAsQueryable()
        {
            return _Entities.AsQueryable();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> where = null, bool AsNoTracking = false, Expression<Func<T, object>> OrderBy = null, OrderByEnum order = OrderByEnum.Descanding, params Expression<Func<T, object>>[] IncludeProperties)
        {
            IQueryable<T> query = _Entities;
            if (IncludeProperties != null)

                foreach (var item in IncludeProperties)
                    query = query.Include(item);

            if (where != null)
                query = query.Where(where);

            if (OrderBy != null)
            {
                if (order == OrderByEnum.Ascending)
                    query = query.OrderBy(OrderBy);
                else
                    query = query.OrderByDescending(OrderBy);
            }

            if (AsNoTracking == true)
                query = query.AsNoTracking();

            return await query.FirstOrDefaultAsync();
        }

        public async Task SoftDeleteAsync(T Entity) // Soft Delete Operasyonu için geçerli bir generic Methoddur. 
        {
            await Task.Run(() =>
            {
                Entity.IsActive = false;
                _Entities.Update(Entity);
            });
        }

        public async Task UpdateAsync(T Entity) // Asenkronik bir method değil bu sebeple kendim asenkropnik bir çevirdim.
        {
            await Task.Run(() => { _Entities.Update(Entity); });
        }
    }
}
