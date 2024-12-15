using Microsoft.AspNetCore.Mvc;

namespace StoreProject.WebUI.ViewComponents.MainLayoutViewComponents
{
	public class _MainLayoutNavbarComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
