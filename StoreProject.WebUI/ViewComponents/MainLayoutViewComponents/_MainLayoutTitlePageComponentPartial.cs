using Microsoft.AspNetCore.Mvc;

namespace StoreProject.WebUI.ViewComponents.MainLayoutViewComponents
{
	public class _MainLayoutTitlePageComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
