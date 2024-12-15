using Microsoft.AspNetCore.Mvc;

namespace StoreProject.WebUI.ViewComponents.MainLayoutViewComponents
{
	public class _MainLayoutFooterComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
