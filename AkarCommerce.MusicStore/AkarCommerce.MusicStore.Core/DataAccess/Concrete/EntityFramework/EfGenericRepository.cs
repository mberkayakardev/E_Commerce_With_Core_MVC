﻿using AkarCommerce.MusicStore.Core.DataAccess.Abstract.EntityFramework;
using AkarCommerce.MusicStore.Core.DataAccess.Concrete.ComplexTypes;
using AkarCommerce.MusicStore.Core.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AkarCommerce.MusicStore.Core.DataAccess.Concrete.EntityFramework
{
    public class EfGenericRepository<T> : IEfGenericRepository<T> where T : class, IEntity, new()
    {
        private readonly DbContext _context;
        private readonly DbSet<T> _entity;
        public EfGenericRepository(DbContext context)
        {
            _context = context;
            _entity  = _context.Set<T>();
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> predicate)
        {
            var result = await _entity.AnyAsync(predicate);
            return result;
        }

        public async Task<int> CountAsync(Expression<Func<T, bool>> predicate = null)
        {
            return (predicate == null) ? await _entity.CountAsync() : await _entity.CountAsync(predicate);
        }

        public async Task CreateAsync(T Entity)
        {
            await _entity.AddAsync(Entity);
        }

        public async Task DeleteAsync(T Entity)
        {
            await Task.Run(() =>
            {
                _entity.Remove(Entity);
            });
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> where = null, bool AsNoTracking = true, Expression<Func<T, object>> OrderByProperty = null, OrderByEnum order = OrderByEnum.Descending, params Expression<Func<T, object>>[] IncludeProperties)
        {
            IQueryable<T> query = _entity;
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
            return _entity.AsQueryable();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> where = null, bool AsNoTracking = false, Expression<Func<T, object>> OrderBy = null, OrderByEnum order = OrderByEnum.Descending, params Expression<Func<T, object>>[] IncludeProperties)
        {
            IQueryable<T> query = _entity;
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

        public async Task UpdateAsync(T Entity)
        {
            await Task.Run(() => { _entity.Update(Entity); });
        }
    }
}
