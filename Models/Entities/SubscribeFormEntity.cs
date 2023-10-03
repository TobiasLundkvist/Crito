using System.ComponentModel.DataAnnotations;

namespace Crito.Models.Entities;

public class SubscribeFormEntity
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Email { get; set; } = null!;
}
