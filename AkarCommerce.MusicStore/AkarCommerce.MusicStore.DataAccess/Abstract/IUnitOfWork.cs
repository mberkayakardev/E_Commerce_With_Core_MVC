using AkarCommerce.MusicStore.Core.DataAccess.Abstract.EntityFramework;
using AkarCommerce.MusicStore.Core.Entities.Abstract;

namespace AkarCommerce.MusicStore.DataAccess.Abstract
{
    public interface IUnitOfWork
    {
        public IEfGenericRepository<T> GetGenericRepostiory<T>() where T : class, IEntity, new();
        public TRepository ReturnRepository<T, TRepository>() where T : BaseEntity, new() where TRepository : IEfGenericRepository<T>, new();
        Task SaveChangesAsync();
        void SaveChanges();

    }
}
