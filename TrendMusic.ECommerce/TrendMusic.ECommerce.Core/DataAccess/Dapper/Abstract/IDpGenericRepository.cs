using TrendMusic.ECommerce.Core.Entities.Abstract;

namespace TrendMusic.ECommerce.Core.DataAccess.Dapper.Abstract
{
    internal interface IDpGenericRepository<T> where T : BaseEntity, new()
    {

    }
}
