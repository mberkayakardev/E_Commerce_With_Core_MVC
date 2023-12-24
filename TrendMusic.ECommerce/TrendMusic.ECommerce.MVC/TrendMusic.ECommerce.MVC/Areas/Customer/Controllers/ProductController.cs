using Microsoft.AspNetCore.Mvc;
using TrendMusic.ECommerce.Core.Utilities.Results.ComplexTypes;
using TrendMusic.ECommerce.Managers.Abstract;

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
        public async Task<IActionResult> Index(string CategoryName)
        {

            if (!string.IsNullOrEmpty(CategoryName))
            {
                var result = await _ProductService.GetAllProductWithCategoryName(CategoryName);
                if (result.Status != ResultStatus.Success)
                {
                    TempData["Message"] = result.Messages;
                }
                return View(result.Data);

            }
            else
            {
                var result = await _ProductService.GetAllProduct();
                if (result.Status != ResultStatus.Success)
                {
                    TempData["Message"] = result.Messages;
                }
                return View(result.Data);
            }

        }

        
    }
}
