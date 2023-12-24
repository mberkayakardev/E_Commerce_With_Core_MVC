using Microsoft.AspNetCore.Mvc;

namespace TrendMusic.ECommerce.MVC.Areas.Customer.Controllers
{
    public class AuthorController : Controller
    {
        /// <summary>
        ///  Tüm sanatçılar listelenecek yada isme göre
        /// </summary>
        /// <returns></returns>
        public IActionResult Index(string AuthorName) 
        {
            return View();
        }
    }
}
