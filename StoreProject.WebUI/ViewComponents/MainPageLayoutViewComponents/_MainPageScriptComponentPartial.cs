using Microsoft.AspNetCore.Mvc;

namespace StoreProject.WebUI.ViewComponents.MainPageLayoutViewComponents
{
	public class _MainPageScriptComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
