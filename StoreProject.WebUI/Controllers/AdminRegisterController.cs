using DtoLayer.LoginRegisterDtos;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace StoreProject.WebUI.Controllers
{
    public class AdminRegisterController : Controller
    {

        private readonly UserManager<AppUser> _userManager;

        public AdminRegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(RegisterDto model)
        {
            if (!ModelState.IsValid)
            {
                return View(model); // Hata mesajları ile formu geri gönder
            }
            AppUser appUser = new AppUser()
            {
                Name = model.Name,
                Email = model.Email,
                Surname = model.Surname,
                UserName = model.UserName,
                ImageUrl = "Test",
                Description = "TEST"
            };

            var result = await _userManager.CreateAsync(appUser, model.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "AdminLogin");

            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);

                }
                return View();

            }

        }
    }
}
