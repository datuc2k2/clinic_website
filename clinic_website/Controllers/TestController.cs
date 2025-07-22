using Microsoft.AspNetCore.Mvc;

namespace clinic_website.Controllers
{
	public class TestController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
