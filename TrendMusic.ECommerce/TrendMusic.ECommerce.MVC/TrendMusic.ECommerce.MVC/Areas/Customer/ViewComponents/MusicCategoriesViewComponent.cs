using Microsoft.AspNetCore.Mvc;
using TrendMusic.ECommerce.Core.Utilities.Results.ComplexTypes;
using TrendMusic.ECommerce.Managers.Abstract;

namespace TrendMusic.ECommerce.MVC.Areas.Customer.ViewComponents
{
    public class MusicCategoriesViewComponent : ViewComponent
    {
        private readonly ICategoryService _categoryService;
        public MusicCategoriesViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var Result = await _categoryService.GetAllCategoriesWithCache();
            
            if (!(Result.Status == ResultStatus.Success))
                TempData["Message"] = Result.Messages.ToString();
            
            return View(Result.Data);

        }
    }
}
