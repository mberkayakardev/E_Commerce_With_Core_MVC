using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace TrendMusic.ECommerce.MVC.Areas.Customer.Controllers
{
	[Area("Customer")]
	public class AccountController : Controller
	{

		[Route("/login")]
		public IActionResult Login()
		{
			return View();
		}
	}
}
