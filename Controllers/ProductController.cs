using Microsoft.AspNetCore.Mvc;
using catalogo_producto_api.Models;
using catalogo_producto_api.Services;
using catalogo_producto_api.DTO;

namespace catalogo_producto_api.Controllers
{
    [ApiController]
    [Route("api")] // Base route for all endpoints in this controller
    public class ProductController : ControllerBase
    {
        private readonly ProductService _service; // Service for product operations
        private readonly ILogger<ProductController> _logger; // Logger for error handling

        // Constructor to inject dependencies
        public ProductController(ProductService service, ILogger<ProductController> logger)
        {
            _service = service;
            _logger = logger;
        }

        // GET: api/products - Retrieve all products
        [HttpGet("products")]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            try
            {
                IEnumerable<Product> products = await _service.GetProducts(); // Fetch all products
                
                return Ok(products); // Return 200 OK with products
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An unexpected error occurred while retrieving products.");
                
                return StatusCode(500, new { message = "An unexpected error occurred" }); // Return 500 on error
            }
        }

        // GET: api/product/{id} - Retrieve a product by ID
        [HttpGet("product")]
        public async Task<ActionResult<Product?>> GetProduct([FromQuery] int id)
        {
            try
            {
                Product? product = await _service.GetProduct(id); // Fetch product by ID

                if (product == null)
                {
                    return NoContent(); // Return 204 No Content if product not found
                }

                return Ok(product); // Return 200 OK with product
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An unexpected error occurred while retrieving a product.");
                
                return StatusCode(500, new { message = "An unexpected error occurred" }); // Return 500 on error
            }
        }

        [HttpPost("products/search")]
        public async Task<ActionResult<IEnumerable<Product>>> GetProductsByName([FromBody] SearchProductDTO dto)
        {
            if (dto == null)
            {
                return BadRequest();
            }

            try
            {
                var Products = await this._service.GetProductsByName(dto.search);

                return Ok(Products);
            }

            catch (Exception ex)
            {
                _logger.LogError(ex, "An unexpected error ocurred");

                return StatusCode(500, new { message = "An unexpected error ocurred" });
            }
        }

        // POST: api/product - Create a new product
        [HttpPost("product")]
        public async Task<ActionResult<Product>> CreateProduct([FromForm] CreateProductDTO body)
        {
            if (body == null)
            {
                return BadRequest();
            }

            try
            {
                var createdProduct = await _service.CreateProduct(body); // Create product
                
                return CreatedAtAction(nameof(GetProduct), new { id = createdProduct.Id }, createdProduct); // Return 201 Created
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An unexpected error occurred while creating a product.");
                
                return StatusCode(500, new { message = "An unexpected error occurred" }); // Return 500 on error
            }
        }

        // PUT: api/product/{id} - Update an existing product
        [HttpPut("product")]
        public async Task<ActionResult<Product>> UpdateProduct([FromQuery] int id, [FromForm] UpdateProductDTO updatedProduct)
        {
            try
            {
                var product = await _service.UpdateProduct(id, updatedProduct); // Update product

                if (product == null)
                {
                    return NotFound(); // Return 404 Not Found if product not found
                }

                return Ok(product); // Return 200 OK with updated product
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An unexpected error occurred while updating a product.");
                
                return StatusCode(500, new { message = "An unexpected error occurred" }); // Return 500 on error
            }
        }

        // DELETE: api/product/{id} - Delete a product by ID
        [HttpDelete("product")]
        public async Task<ActionResult<Product>> DeleteProduct([FromQuery] int id)
        {
            try
            {
                var product = await _service.DeleteProduct(id); // Delete product

                if (product == null)
                {
                    return NotFound(); // Return 404 Not Found if product not found
                }

                return Ok(product); // Return 200 OK with deleted product
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An unexpected error occurred while deleting a product.");
                
                return StatusCode(500, new { message = "An unexpected error occurred" }); // Return 500 on error
            }
        }
    }
}