using Microsoft.AspNetCore.Mvc;

namespace StoreProject.WebUI.Controllers
{
    public class HomePageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
