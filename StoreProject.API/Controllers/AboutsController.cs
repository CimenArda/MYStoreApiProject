using BusinessLayer.Abstract;
using DtoLayer.AboutDtos;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StoreProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController : ControllerBase
    {
        private readonly IAboutService _AboutService;

        public AboutsController(IAboutService AboutService)
        {
            _AboutService = AboutService;
        }


        [HttpGet]
        public IActionResult AboutList()
        {
            var values = _AboutService.TGetAllList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateAbout(CreateAboutDto createAboutDto)
        {
            _AboutService.TInsert(new About()
            {
                OurStory = createAboutDto.OurStory,
                OurMission = createAboutDto.OurMission,
                ImageUrl1 = createAboutDto.ImageUrl1,
                ImageUrl2 = createAboutDto.ImageUrl2
            });
            return Ok("About eklendi");

        }

        [HttpDelete]
        public IActionResult DeleteAbout(int id)
        {
            _AboutService.TDelete(id);
            return Ok("About Silme Başarılı");

        }

        [HttpGet("{id}")]
        public IActionResult GetAbout(int id)
        {
            var value = _AboutService.TGetById(id);
            return Ok(value);
        }


        [HttpPut]
        public IActionResult UpdateAbout(UpdateAboutDto updateAboutDto)
        {
            _AboutService.TUpdate(new About()
            {
                AboutID = updateAboutDto.AboutID,
                OurStory = updateAboutDto.OurStory,
                OurMission = updateAboutDto.OurMission,
                ImageUrl1 = updateAboutDto.ImageUrl1,
                ImageUrl2 = updateAboutDto.ImageUrl2

            });
            return Ok("About  güncellendi");
        }
    }
}
