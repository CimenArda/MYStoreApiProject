using Microsoft.AspNetCore.Mvc;

namespace StoreProject.WebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
