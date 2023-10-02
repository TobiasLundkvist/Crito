using System.ComponentModel.DataAnnotations;

namespace Crito.Models.Entities
{
    public class ContactFormEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string Email { get; set; } = null!;

        [Required]
        [StringLength(100)]
        public string Message { get; set; } = null!;
    }
}
