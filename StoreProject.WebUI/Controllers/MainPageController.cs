using Microsoft.AspNetCore.Mvc;

namespace StoreProject.WebUI.Controllers
{
    public class MainPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
