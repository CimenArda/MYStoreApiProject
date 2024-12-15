using Microsoft.AspNetCore.Mvc;

namespace StoreProject.WebUI.ViewComponents.MainLayoutViewComponents
{
	public class _MainLayoutScriptComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
