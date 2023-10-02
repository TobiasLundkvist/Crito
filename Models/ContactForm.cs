using Crito.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace Crito.Models;

public class ContactForm
{
    [Required(ErrorMessage = "You need to enter your name")]
    public string Name { get; set; } = null!;

    [Required(ErrorMessage = "You need to enter a valid E-mail")]
    [EmailAddress]
    public string Email { get; set; } = null!;

    [Required(ErrorMessage = "You need to enter a message")]
    public string Message { get; set; } = null!;

    public string? RedirectUrl { get; set; } = "/";
}
