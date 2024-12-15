using BusinessLayer.Abstract;
using DtoLayer.ProductDtos;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StoreProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }


        [HttpGet]
        public IActionResult ProductList()
        {
            var values = _productService.TGetAllList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateProduct(CreateProductDto createProductDto)
        {
            _productService.TInsert(new Product()
            {
               Name = createProductDto.Name,
               CategoryID = createProductDto.CategoryID,
               Description = createProductDto.Description,
               ImageUrl1 = createProductDto.ImageUrl1,
               ImageUrl2 = createProductDto.ImageUrl2,
               ImageUrl3 = createProductDto.ImageUrl3,
               Price = createProductDto.Price,
               Title = createProductDto.Title
            });
            return Ok("Product eklendi");

        }

        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            _productService.TDelete(id);
            return Ok("Product Silme Başarılı");

        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var value = _productService.TGetById(id);
            return Ok(value);
        }




        [HttpPut]
        public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
        {
            _productService.TUpdate(new Product()
            {
                ProductID = updateProductDto.ProductID,
                Name = updateProductDto.Name,
                CategoryID = updateProductDto.CategoryID,
                Description = updateProductDto.Description,
                ImageUrl1 = updateProductDto.ImageUrl1,
                ImageUrl2 = updateProductDto.ImageUrl2,
                ImageUrl3 = updateProductDto.ImageUrl3,
                Price = updateProductDto.Price,
                Title = updateProductDto.Title
            });
            return Ok("Product  güncellendi");
        }



        [HttpGet("GetProductsWithCategory")]
        public List<ResultProductWithCategoryDto> GetProductsWithCategory()
        {
            var value = _productService.TGetProductsWithCategory();
            return value.Select(p=> new ResultProductWithCategoryDto
            {
                ProductID = p.ProductID,
                Name = p.Name,
                CategoryName = p.Category.CategoryName,
                CategoryID = p.CategoryID,
                Description = p.Description,
                ImageUrl1 = p.ImageUrl1,
                ImageUrl2 = p.ImageUrl2,
                ImageUrl3 = p.ImageUrl3,
                Price = p.Price,
                Title = p.Title
            }).ToList();

           
        }

        [HttpGet("ProductCount")]
        public IActionResult ProductCount()
        {
            return Ok(_productService.TProductCount());
        }


        [HttpGet("MaxPriceProductName")]
        public IActionResult MaxPriceProductName()
        {
            return Ok(_productService.TMaxPriceProductName());
        }


    }
}
