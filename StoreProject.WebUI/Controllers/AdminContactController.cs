using DataAccessLayer.Concrete;
using DtoLayer.CategoryDtos;
using DtoLayer.ContactDtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace StoreProject.WebUI.Controllers
{
    public class AdminContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly StoreContext _context;
        public AdminContactController(IHttpClientFactory httpClientFactory, StoreContext context)
        {
            _httpClientFactory = httpClientFactory;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7110/api/Contacts");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<List<ResultContactDto>>(jsonData);


                return View(value);

            }
            return View();

        }
        public IActionResult GetContactDetail(int id)
        {
            var contact = _context.Contacts // İlgili DbSet
                .Where(x => x.Id == id)
                .Select(x => new
                {
                    x.Id,
                    x.Email,
                    x.Description
                })
                .FirstOrDefault();

            if (contact == null)
            {
                return NotFound();
            }

            return Json(contact);
        }


        public async Task<IActionResult> DeleteContact(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync("https://localhost:7110/api/Contacts?id=" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "AdminContact");
            }
            return View();
        }

    }
}
