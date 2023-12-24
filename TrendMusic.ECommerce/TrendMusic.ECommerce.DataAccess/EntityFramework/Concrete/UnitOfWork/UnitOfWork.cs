using TrendMusic.ECommerce.Core.DataAccess.EntityFramework.Abstract;
using TrendMusic.ECommerce.Core.DataAccess.EntityFramework.Concrete;
using TrendMusic.ECommerce.Core.Entities.Abstract;
using TrendMusic.ECommerce.DataAccess.EntityFramework.Abstract;
using TrendMusic.ECommerce.DataAccess.EntityFramework.Concrete.Contexts;
using TrendMusic.ECommerce.DataAccess.EntityFramework.Concrete.Repositories;

namespace TrendMusic.ECommerce.DataAccess.EntityFramework.Concrete.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyDbContext _dbContexts;

        /// <summary>
        /// sadece propert olrak nasıl çağrılabileceği bir örnek oluşturulması maksadı ile eklenmiştir. işlevi yok 
        /// </summary>
        #region RepositoryProperties

        public IProductRepository ProductRepository { get { return new ProductRepository(_dbContexts); } }
        #endregion

        public UnitOfWork(MyDbContext myDbContexts)
        {
            _dbContexts = myDbContexts;
        }

        #region SaveChanges
        public void SaveChanges()
        {
            _dbContexts.SaveChanges();
        }
        public async Task SaveChangesAsync()
        {
            await _dbContexts.SaveChangesAsync();
        }
        #endregion

        IEfGenericRepository<T> IUnitOfWork.GetGenericRepository<T>()
        {
            return new EfGenericRepository<T>(_dbContexts);
        }

        /// <summary>
        /// Vermiş olduğunuz Entity ve O entity e hizmet eden Reposiytory nin fiziksel hali verildiğinde (abstract olmayan) sizlere otomatik olarak ilgili repsotiory nin instance ini verecektir. ek olarak buraya eklendi tek tek property çağrımanın önünge geçilebilmesi için 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TRepository"></typeparam>
        [Obsolete("Verdiğiniz class a göre ilgili class i dinamik bir şekilde instance aldırır ama artık kullanılamaz.")]
        public TRepository ReturnRepository<T, TRepository>() where T : BaseEntity, new() where TRepository : IEfGenericRepository<T>, new()
        {
            var repository = (TRepository)Activator.CreateInstance(typeof(TRepository), _dbContexts);
            return repository;
        }

    }
}
