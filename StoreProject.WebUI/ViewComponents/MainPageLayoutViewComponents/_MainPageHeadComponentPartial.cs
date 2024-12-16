using Microsoft.AspNetCore.Mvc;

namespace StoreProject.WebUI.ViewComponents.MainPageLayoutViewComponents
{
	public class _MainPageHeadComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
