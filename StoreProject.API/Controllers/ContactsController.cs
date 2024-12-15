using BusinessLayer.Abstract;
using DtoLayer.ContactDtos;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StoreProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactService _ContactService;

        public ContactsController(IContactService ContactService)
        {
            _ContactService = ContactService;
        }


        [HttpGet]
        public IActionResult ContactList()
        {
            var values = _ContactService.TGetAllList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateContact(CreateContactDto createContactDto)
        {
            _ContactService.TInsert(new Contact()
            {
               Email = createContactDto.Email,
               Description = createContactDto.Description
            });
            return Ok("Contact eklendi");

        }

        [HttpDelete]
        public IActionResult DeleteContact(int id)
        {
            _ContactService.TDelete(id);
            return Ok("Contact Silme Başarılı");

        }

        [HttpGet("{id}")]
        public IActionResult GetContact(int id)
        {
            var value = _ContactService.TGetById(id);
            return Ok(value);
        }


        [HttpPut]
        public IActionResult UpdateContact(UpdateContactDto updateContactDto)
        {
            _ContactService.TUpdate(new Contact()
            {
              Email=updateContactDto.Email,
              Description=updateContactDto.Description,
              Id =updateContactDto.Id

            });
            return Ok("Contact  güncellendi");
        }

        [HttpGet("ContactCount")]
        public IActionResult ContactCount()
        {
         return Ok(_ContactService.TContactCount());
        }
    }
}
