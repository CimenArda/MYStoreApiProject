using DtoLayer.FeatureDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace StoreProject.WebUI.ViewComponents.MainPageLayoutViewComponents
{
	public class _MainPageSliderComponentPartial : ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public _MainPageSliderComponentPartial(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7110/api/Features");

			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var value = JsonConvert.DeserializeObject<List<ResultFeatureDto>>(jsonData);


				return View(value);

			}
			return View();

		}
	}
}
