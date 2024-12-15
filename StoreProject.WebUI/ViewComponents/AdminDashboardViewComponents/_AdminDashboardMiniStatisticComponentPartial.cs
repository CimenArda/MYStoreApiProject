using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;

namespace StoreProject.WebUI.ViewComponents.AdminDashboardViewComponents
{
	public class _AdminDashboardMiniStatisticComponentPartial : ViewComponent
	{
        private readonly IHttpClientFactory _httpClientFactory;
        public _AdminDashboardMiniStatisticComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();

            // Contacts Count
            var responseMessage = await client.GetAsync("https://localhost:7110/api/Contacts/ContactCount");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var contactCount = JsonConvert.DeserializeObject<int>(jsonData); 
                ViewBag.contactcount = contactCount;
            }

            // Category Count
            var responseMessage2 = await client.GetAsync("https://localhost:7110/api/Categorys/CategoryCount");
            if (responseMessage2.IsSuccessStatusCode)
            {
                var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
                var categoryCount = JsonConvert.DeserializeObject<int>(jsonData2); 
                ViewBag.categoryCount = categoryCount;
            }

            // Product Count
            var responseMessage3 = await client.GetAsync("https://localhost:7110/api/Products/ProductCount");
            if (responseMessage3.IsSuccessStatusCode)
            {
                var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
                var productCount = JsonConvert.DeserializeObject<int>(jsonData3); 
                ViewBag.productCount = productCount;
            }

            // Product Name
            var responseMessage4 = await client.GetAsync("https://localhost:7110/api/Products/MaxPriceProductName");
            if (responseMessage4.IsSuccessStatusCode)
            {
                var productName = await responseMessage4.Content.ReadAsStringAsync(); 
                ViewBag.productName = productName; 
            }

            return View();
        }

    }
}
