using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application_For_Infopulse.Server.Services;
using Application_For_Infopulse.Shared.Models;

namespace Application_For_Infopulse.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductService _productService;
        public ProductsController(ProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]      
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _productService.GetAllAsync());
        }

        [HttpPost]
        public async Task<IActionResult> CreateProductAsync(Product product)
        {
            try
            {
                await _productService.CreateProductAsync(product);
                return Ok();
            } catch
            {
                return StatusCode(500, "Product not created");
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProductAsync([FromQuery] long productId)
        {
            try
            {
                await _productService.DeleteProductAsync(productId);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
