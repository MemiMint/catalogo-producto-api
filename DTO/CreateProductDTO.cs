using Microsoft.AspNetCore.Http;

namespace catalogo_producto_api.DTO
{
    public class CreateProductDTO
    {
        public required IFormFile File { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required decimal Price { get; set; }
        public required int Stock { get; set; }
    }
}