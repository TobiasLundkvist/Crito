using System.ComponentModel.DataAnnotations;

namespace Crito.Models;

public class SubscribeFormModel
{
    [Required(ErrorMessage = "You need to enter a valid E-mail")]
    [EmailAddress]
    public string Email { get; set; } = null!;

    public string? RedirectUrl { get; set; } = "/";
}
