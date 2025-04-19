using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Nombre de Categoría")]
        [MaxLength(30, ErrorMessage ="Nombre de Categoría no puede ser mayor de 30 caracteres.")]
        public string? Name { get; set; }

        [DisplayName("Orden Visual")]
        [Range(1, 100, ErrorMessage = "Orden visual debe estar entre 1 y 100.")]
        public int DisplayOrder { get; set; }
    }
}
