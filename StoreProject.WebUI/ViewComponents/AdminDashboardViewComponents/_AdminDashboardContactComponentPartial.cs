using DataAccessLayer.Concrete;
using DtoLayer.ContactDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace StoreProject.WebUI.ViewComponents.AdminDashboardViewComponents
{
    public class _AdminDashboardContactComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly StoreContext _context;
        public _AdminDashboardContactComponentPartial(IHttpClientFactory httpClientFactory, StoreContext context)
        {
            _httpClientFactory = httpClientFactory;
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
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
    }
}
