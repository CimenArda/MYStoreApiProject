using BusinessLayer.Abstract;
using DtoLayer.FeatureDtos;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StoreProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeaturesController : ControllerBase
    {

        private readonly IFeatureService _FeatureService;

        public FeaturesController(IFeatureService FeatureService)
        {
            _FeatureService = FeatureService;
        }


        [HttpGet]
        public IActionResult FeatureList()
        {
            var values = _FeatureService.TGetAllList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateFeature(CreateFeatureDto createFeatureDto)
        {
            _FeatureService.TInsert(new Feature()
            {
               Title = createFeatureDto.Title,
               ImageUrl = createFeatureDto.ImageUrl,
                Description = createFeatureDto.Description
            });
            return Ok("Feature eklendi");

        }

        [HttpDelete]
        public IActionResult DeleteFeature(int id)
        {
            _FeatureService.TDelete(id);
            return Ok("Feature Silme Başarılı");

        }

        [HttpGet("{id}")]
        public IActionResult GetFeature(int id)
        {
            var value = _FeatureService.TGetById(id);
            return Ok(value);
        }


        [HttpPut]
        public IActionResult UpdateFeature(UpdateFeatureDto updateFeatureDto)
        {
            _FeatureService.TUpdate(new Feature()
            {
                FeatureID = updateFeatureDto.FeatureID,
                Title = updateFeatureDto.Title,
                ImageUrl = updateFeatureDto.ImageUrl,
                Description = updateFeatureDto.Description

            });
            return Ok("Feature  güncellendi");
        }


    }
}
