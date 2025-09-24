using Microsoft.AspNetCore.Mvc;

namespace LinkStats.Web.Controllers
{
	public class AuthController : Controller
	{
		[Route("/Auth/")]
		public IActionResult Index()
		{
			return View();
		}
	}
}
