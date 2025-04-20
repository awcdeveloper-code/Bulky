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
        public string? Name { get; set; }

        [DisplayName("Estado")]
        public int Status { get; set; }

        [DisplayName("Creado")]
        public DateTime CreatedAt { get; set; }

        [DisplayName("Modificado")]
        public DateTime LastLogin { get; set; }
    }
}
