using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bulky.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("No. PIN")]
        public int PIN { get; set; }

        [Required]
        [DisplayName("Nombre")]
        [StringLength(20, ErrorMessage = "El nombre no puede exceder los 20 caracteres.")]
        public string? Name { get; set; }

        [Required]
        [DisplayName("Estado")]
        [Range(0, 1, ErrorMessage = "El estado debe estar entre 0 y 5.")]
        public int Status { get; set; }

        [DisplayName("Creado")]
        public DateTime CreatedAt { get; set; }

        [DisplayName("Modificado")]
        public DateTime LastLogin { get; set; }
    }
}
