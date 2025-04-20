using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bulky.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [DisplayName("Producto")]
        [Range(0, 25, ErrorMessage = "Producto debe ser entre 0 y 25")]
        public int Category { get; set; } = 0;
        
        [Required]
        [DisplayName("Subproducto")]
        [Range(0, 5, ErrorMessage = "Subproducto debe ser entre 0 y 5")]
        public int SubCategory { get; set; } = 0;

        [DisplayName("Nombre de Producto")]
        [MaxLength(30, ErrorMessage = "Nombre de Producto no puede ser mayor de 30 caracteres.")]
        public string? Name { get; set; } = string.Empty;
        
        [Required]
        [DisplayName("Costo")]
        [Range(1.00, 999.99, ErrorMessage = "Costo debe ser entre 1.00 y 999999.00")]
        public decimal UnitCost { get; set; } = 0.00m;
        
        [Required]
        [DisplayName("Precio")]
        [Range(1.00, 999.99, ErrorMessage = "Precio debe ser entre 1.00 y 999999.00")]
        public decimal UnitPrice { get; set; } = 0.00m;
        
        [Required]
        [DisplayName("Disponibles")]
        public int CurrentStock { get; set; } = 0;

        [Required]
        [DisplayName("´Mínimo")]
        [Range(10, 25, ErrorMessage = "Mínimo debe ser entre 1 y 25")]
        public int ReorderLevel { get; set; } = 0;

        [Required]
        [DisplayName("Estado")]
        [Range(0, 5, ErrorMessage = "Estado debe ser entre 1 y 5")]
        public int Status { get; set; } = 0;
    }
}
