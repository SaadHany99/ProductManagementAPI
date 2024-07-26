using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductManagementAPI.Models;
using ProductManagementAPI.Services;

namespace ProductManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService service;

        public ProductController(IProductService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllProducts()
        {
            var products = await service.GetProducts();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetProductById(int id)
        {
            var product = await service.GetProductById(id);
            if (product == null)
                return NotFound();
            return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult> AddProduct(Product product)
        {
            await service.AddProduct(product);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> EditProduct(int id,Product product)
        {
            product.Id = id;
            if (product==null)
                return BadRequest();
            await service.UpdateProduct(product);
               return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteProduct(int id)
        {
            var product = await service.GetProductById(id);
            if (product == null)
                return NotFound();
            await service.DeleteProduct(product);
               return NoContent();
        }
    }
}
