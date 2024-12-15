using BusinessLayer.Abstract;
using DtoLayer.CategoryDtos;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StoreProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategorysController : ControllerBase
    {
        private readonly ICategoryService _CategoryService;

        public CategorysController(ICategoryService CategoryService)
        {
            _CategoryService = CategoryService;
        }


        [HttpGet]
        public IActionResult CategoryList()
        {
            var values = _CategoryService.TGetAllList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryDto createCategoryDto)
        {
            _CategoryService.TInsert(new Category()
            {
                CategoryName = createCategoryDto.CategoryName,
               
            });
            return Ok("Category eklendi");

        }

        [HttpDelete]
        public IActionResult DeleteCategory(int id)
        {
            _CategoryService.TDelete(id);
            return Ok("Category Silme Başarılı");

        }

        [HttpGet("{id}")]
        public IActionResult GetCategory(int id)
        {
            var value = _CategoryService.TGetById(id);
            return Ok(value);
        }


        [HttpPut]
        public IActionResult UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            _CategoryService.TUpdate(new Category()
            {
                CategoryID = updateCategoryDto.CategoryID,
                CategoryName = updateCategoryDto.CategoryName
               
            });
            return Ok("Category  güncellendi");
        }

        [HttpGet("CategoryCount")]
        public IActionResult CategoryCount()
        {
            return Ok(_CategoryService.TCategoryCount());
        }
    }
}
