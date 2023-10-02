using Crito.Contexts;
using Crito.Models;
using Crito.Models.Entities;

namespace Crito.Services;

public class ContactFormService
{
    private readonly DataContext _context;


    public ContactFormService(DataContext context)
    {
        _context = context;
    }

    public async Task CreateMessage(ContactForm contactForm)
    {
        _context.ContactUs.Add(new ContactFormEntity { Name = contactForm.Name, Email = contactForm.Email, Message = contactForm.Message});
        await _context.SaveChangesAsync();
    }
}
