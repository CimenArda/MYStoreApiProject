using Microsoft.AspNetCore.Mvc;

namespace StoreProject.WebUI.ViewComponents.AdminLayoutViewComponents
{
    public class _AdminLayoutScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
