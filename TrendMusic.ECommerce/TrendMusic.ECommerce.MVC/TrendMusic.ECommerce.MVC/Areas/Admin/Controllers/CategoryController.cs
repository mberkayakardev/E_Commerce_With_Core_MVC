using Microsoft.AspNetCore.Mvc;

namespace TrendMusic.ECommerce.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
              
        }
    }
}
