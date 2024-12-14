using Microsoft.AspNetCore.Mvc;

namespace StoreProject.WebUI.ViewComponents.AdminLayoutViewComponents
{
    public class _AdminLayoutFooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
