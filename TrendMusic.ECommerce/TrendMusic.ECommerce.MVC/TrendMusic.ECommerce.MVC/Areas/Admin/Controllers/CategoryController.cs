using Microsoft.AspNetCore.Mvc;

namespace TrendMusic.ECommerce.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly 
        public CategoryController()
        {
            
        }

        public IActionResult Index()
        {
            
            
            return View();
              
        }
    }
}
