using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace AkarCommerce.MusicStore.UI.Controllers
{

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
