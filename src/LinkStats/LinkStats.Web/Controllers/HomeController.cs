using Microsoft.AspNetCore.Mvc;

namespace LinkStats.Web.Controllers
{
	[Route("{controller}/{action}")]
	public class HomeController : BaseController
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

		public IActionResult ContactUs()
		{
			return View();
		}
	}
}
