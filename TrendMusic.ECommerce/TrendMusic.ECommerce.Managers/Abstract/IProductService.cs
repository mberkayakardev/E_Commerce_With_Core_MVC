using TrendMusic.ECommerce.Core.Utilities.Pagination.ComplexTypes;
using TrendMusic.ECommerce.Core.Utilities.Results.BaseResult;
using TrendMusic.ECommerce.Dtos.Concrete.Product;
using TrendMusic.ECommerce.Managers.Concrete.ComplexTypes.Product;

namespace TrendMusic.ECommerce.Managers.Abstract
{
    public interface IProductService
    {
        /// <summary>
        /// Ürün eklememizi sağlamaktadır 
        /// </summary>
        Task<IDataResult<ProductAddDto>> AddProduct(ProductAddDto dto);
        
        /// <summary>
        /// Tüm ürünlerin gösterimini sağlamaktadır (Silinmemiş olanlar için)
        /// </summary>
        Task<IDataResult<List<ProductListDto>>> GetAllProduct();

        /// <summary>
        /// Tüm ürünler Search Model neticesinde bir aramaya tabidir. 
        /// </summary>
        Task<IDataResult<List<ProductListDto>>> GetAllProductWithSearchModel(ProductSearchModel productSearchModel); 
        
        /// <summary>
        /// Admin tarafı için silinen içerikler de beraberinde gelir. 
        /// </summary>
        Task<IDataResult<List<ProductListDto>>> GetAllProductWithDeleted();

        /// Pager İle verilerin listelenmesi baz alınır 
        Task<(MetaData MetaData, IDataResult<List<ProductListDto>>)> GetAllProductWithSearchModelAndPaging(ProductSearchModel productSearchModel);


    }
}
