using Microsoft.AspNetCore.Mvc;

namespace StoreProject.WebUI.ViewComponents.MainLayoutViewComponents
{
	public class _MainLayoutHeadComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
