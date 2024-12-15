using Microsoft.AspNetCore.Mvc;

namespace StoreProject.WebUI.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
