using Microsoft.AspNetCore.Mvc;

namespace Crito.Views.Contacts
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
