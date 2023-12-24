using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace TrendMusic.ECommerce.MVC.Areas.Customer.Controllers
{
	[Area("Customer")]
	public class AccountController : Controller
	{

		[Route("/singin")]
		public IActionResult Login()
		{
			return View();
		}


		[Route("/singin/facebook")]
		public IActionResult LoginWithFacebook()
		{
			return View();
		}

		[Route("/singin/google")]
		public IActionResult LoginWithGoogle()
		{
			return View();
		}


		[Route("/singout")]
		public IActionResult singout()
		{
			return View();
		}

		[Route("/register")]
		public IActionResult Register()
		{
			return View();
		}


	}
}
