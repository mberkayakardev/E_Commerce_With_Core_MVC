using TrendMusic.ECommerce.Core.Utilities.Results.BaseResult;
using TrendMusic.ECommerce.Dtos.Concrete.Product;

namespace TrendMusic.ECommerce.Managers.Abstract
{
    public interface IProductService
    {
        Task<IDataResult<ProductAddDto>> AddProduct(ProductAddDto dto);
    }
}
