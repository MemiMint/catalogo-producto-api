using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace catalogo_producto_api.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column("ImageURL")]
        public required string ImageUrl { get; set; }

        [Required]
        [Column("Name")]
        public required string Name { get; set; }
        
        [Required]
        [Column("Description")]
        public required string Description { get; set; }
        
        [Required]
        [Column("Price", TypeName = "decimal(12, 2)")]
        public decimal Price { get; set; }

        [Required]
        [Column("Stock")]
        public int Stock { get; set; }
    }
}
