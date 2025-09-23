using Microsoft.AspNetCore.Mvc;

namespace LinkStats.Web.Controllers
{
	public class HomeController : Controller
	{
		[Route("/")]
		public IActionResult Index()
		{
			return View();
		}

		[Route("/about-us")]
		public IActionResult AboutUs()
		{
			return View();
		}

		[Route("/Home/ContactUs")]
		public IActionResult ContactUs()
		{
			return View();
		}
	}
}
