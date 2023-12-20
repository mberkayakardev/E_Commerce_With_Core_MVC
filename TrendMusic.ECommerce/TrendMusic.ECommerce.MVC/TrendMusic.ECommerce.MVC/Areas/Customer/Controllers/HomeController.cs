using Microsoft.AspNetCore.Mvc;

namespace TrendMusic.ECommerce.MVC.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


    }


}
