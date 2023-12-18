
using TrendMusic.ECommerce.Core.DataAccess.Dapper.Abstract;
using TrendMusic.ECommerce.Core.Entities.Abstract;

namespace TrendMusic.ECommerce.Core.DataAccess.Dapper.Concrete
{
    public  class DpGenericRepository<T> : IDpGenericRepository<T> where T: BaseEntity, new()
    {

    }
}
