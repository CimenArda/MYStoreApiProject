using Microsoft.AspNetCore.Mvc;

namespace StoreProject.WebUI.Controllers
{
    public class AdminDashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
