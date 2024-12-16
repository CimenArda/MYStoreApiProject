using Microsoft.AspNetCore.Mvc;

namespace StoreProject.WebUI.ViewComponents.MainPageLayoutViewComponents
{
	public class _MainPageBannerComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
