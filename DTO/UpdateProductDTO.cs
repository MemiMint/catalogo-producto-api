namespace catalogo_producto_api.DTO
{
    public class UpdateProductDTO
    {
        public required IFormFile File { get; set; }
        public required string Name { get; set; }

        public required string Description { get; set; }

        public required decimal Price { get; set; }

        public required int Stock { get; set; }
    }
}
