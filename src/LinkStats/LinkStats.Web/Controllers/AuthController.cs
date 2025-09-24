using Microsoft.AspNetCore.Mvc;

namespace LinkStats.Web.Controllers
{
	[Route("{controller}/{action}")]
	public class AuthController : BaseController
	{
		[HttpGet]
		public IActionResult SignUp()
		{
			return View();
		}


		[HttpPost]
		public IActionResult SignUp(string Name, string Email, string Password)
		{
			return RedirectToAction("Index", "Home");
		}


	}
}
