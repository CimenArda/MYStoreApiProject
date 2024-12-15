using DtoLayer.CategoryDtos;
using DtoLayer.ContactDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace StoreProject.WebUI.Controllers
{
	public class ContactController : Controller
	{

		private readonly IHttpClientFactory _httpClientFactory;

		public ContactController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}


		public IActionResult Index()
		{
			return View();
		}


		[HttpPost]
		public async Task<IActionResult> Index(CreateContactDto createContactDto)
		{

			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(createContactDto);
			StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var responseMessage = await client.PostAsync("https://localhost:7110/api/Contacts", stringContent);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index", "HomePage");
			}
			return View();
		}
	}
}
