using Microsoft.AspNetCore.Mvc;
using TrendMusic.ECommerce.Core.Utilities.Pagination.ComplexTypes;
using TrendMusic.ECommerce.Core.Utilities.Results.ComplexTypes;
using TrendMusic.ECommerce.Dtos.Concrete.Product;
using TrendMusic.ECommerce.Managers.Abstract;
using TrendMusic.ECommerce.Managers.Concrete.ComplexTypes.Product;

namespace TrendMusic.ECommerce.MVC.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class ProductController : Controller
    {
        private readonly IProductService _ProductService;
        public ProductController(IProductService productService)
        {
            _ProductService = productService;
        }

        /// <summary>
        /// Tüm ürünler listelenecektir.veya gelen filtreye göre bir listeleme işlemi söz konusudur.  
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Index(ProductSearchModel? ProductSearchModel)
        {
            var result = await _ProductService.GetAllProductWithSearchModelAndPaging(ProductSearchModel);
            if (result.Item2.Status == ResultStatus.Success)
            {
                return View(new PagerResultViewModel<List<ProductListDto>>(result.MetaData, result.Item2.Data));
            }
            else
            {
                TempData["Message"] = result.Item2.Messages;
                return View(new PagerResultViewModel<List<ProductListDto>>(default, default));
            }


        }

        
    }
}
