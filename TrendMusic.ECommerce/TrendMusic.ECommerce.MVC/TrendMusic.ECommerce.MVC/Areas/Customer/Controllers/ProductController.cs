using Microsoft.AspNetCore.Mvc;

namespace TrendMusic.ECommerce.MVC.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Deneme()
        {
            return View();
        }
    }
}
