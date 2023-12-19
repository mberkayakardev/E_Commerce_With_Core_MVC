using TrendMusic.ECommerce.Core.Utilities.Results.BaseResult;
using TrendMusic.ECommerce.Dtos.Concrete.Category;

namespace TrendMusic.ECommerce.Managers.Abstract
{
    public interface ICategoryService
    {
        Task<IDataResult<List<CategoryListDto>>> GetAllCategories();
    }
}
