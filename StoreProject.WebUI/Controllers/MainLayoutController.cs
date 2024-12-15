using Microsoft.AspNetCore.Mvc;

namespace StoreProject.WebUI.Controllers
{
	public class MainLayoutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
