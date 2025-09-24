using Microsoft.AspNetCore.Mvc;

namespace LinkStats.Web.Controllers
{
	public class AuthController : Controller
	{
		[Route("/Auth/SignUp")]
		public IActionResult SignUp()
		{
			return View();
		}
	}
}
