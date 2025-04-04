using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WhareHouseAutomation.Models;
using WhareHouseAutomation.Service;

namespace WhareHouseAutomation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        
        private readonly IRepository<Product> _productRepository;

        public ProductsController(IRepository<Product> productRepository) 
        {
            _productRepository = productRepository;
        }

        [HttpPost("AddProduct")]
        public async Task<ActionResult> AddProductAsync(Product product)
        {
            await _productRepository.AddAsync(product);
            return Ok(product);
        }
        [HttpDelete("RemoveProductAsync")]
        public async Task<ActionResult> RemoveProductAsync(int id)
        {
            await _productRepository.DeleteAsync(id);
            return Ok();
        }
        [HttpGet("GetByProductAsync")]
        public async Task<ActionResult<Product>> GetByProductAsync(int id)
        {
            var product = await _productRepository.GetByAsync(id);
            return Ok(product);
        }
        [HttpGet("GetAllProductsAsync")]
        public async Task<ActionResult<IEnumerable<Product>>> GetAllProductsAsync()
        {
            var products = await _productRepository.GetAllAsync();
            return Ok(products);
        }
        [HttpPut("UpdateProductAsync")]
        public async Task<ActionResult> UpdateProductAsync( Product product)
        {
            await _productRepository.UpdateAsync(product);
            return Ok(product);
        }
        
    }
}
