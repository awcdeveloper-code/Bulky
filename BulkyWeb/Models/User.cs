using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int PIN { get; set; }
        [Required]
        public string? Name { get; set; }
        public int Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastLogin { get; set; }
    }
}
