using DtoLayer.ProductDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace StoreProject.WebUI.ViewComponents.MainPageLayoutViewComponents
{
	public class _MainPageProductComponentPartial : ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public _MainPageProductComponentPartial(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7110/api/Products/GetProductsWithCategory");

			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var value = JsonConvert.DeserializeObject<List<ResultProductDto>>(jsonData);


				return View(value);

			}

			return View();
		}


	}
}
