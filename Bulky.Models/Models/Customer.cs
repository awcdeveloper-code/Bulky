using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bulky.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Tipo de Cliente")]
        [Range(1, 9, ErrorMessage = "Tipo de Cliente debe estar entre 0 y 9.")]
        public int Type { get; set; } = 0;

        [Required]
        [DisplayName("Nombre")]
        [StringLength(20, ErrorMessage = "Nombre no debe estar entre 1 y 20 caracteres.")]
        public string? Name { get; set; } = string.Empty;

        [Required]
        [DisplayName("Estado")]
        [Range(0, 3, ErrorMessage = "Estado debe estar entre 0 y 3.")]
        public int Status { get; set; } = 0;

        public DateTime CreatedAt { get; set; }

        public DateTime LastUpdate { get; set; }
    }
}
