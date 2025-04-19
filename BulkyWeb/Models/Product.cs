using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [DisplayName("Categoría")]
        public int Category { get; set; } = 0;
        
        [Required]
        public int SubCategory { get; set; } = 0;

        [DisplayName("Nombre de Producto")]
        [MaxLength(30, ErrorMessage = "Nombre de Producto no puede ser mayor de 30 caracteres.")]
        public string? Name { get; set; } = string.Empty;
        
        [Required]
        public decimal UnitCost { get; set; } = 0.00m;
        
        [Required]
        public decimal UnitPrice { get; set; } = 0.00m;
        
        [Required]
        public int CurrentStock { get; set; } = 0;

        [Required]
        public int ReorderLevel { get; set; } = 0;

        [Required]
        public int Status { get; set; } = 0;
    }
}
