﻿using TrendMusic.ECommerce.Core.DataAccess.EntityFramework.Abstract;
using TrendMusic.ECommerce.Core.Entities.Abstract;

namespace TrendMusic.ECommerce.DataAccess.EntityFramework.Abstract
{
    public interface IUnitOfWork
    {
        #region Repositories 
        IProductRepository ProductRepository { get; }
        #endregion

        public IEfGenericRepository<T> GetGenericRepository<T>() where T : class, IEntity, new();
        public TRepository ReturnRepository<T, TRepository>() where T : BaseEntity, new() where TRepository : IEfGenericRepository<T>, new();
        Task SaveChangesAsync();
        void SaveChanges();
    }
}
