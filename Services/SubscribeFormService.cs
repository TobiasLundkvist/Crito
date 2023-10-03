using Crito.Contexts;
using Crito.Models;
using Crito.Models.Entities;

namespace Crito.Services;

public class SubscribeFormService
{
    private readonly DataContext _context;

    public SubscribeFormService(DataContext context)
    {
        _context = context;
    }

    public async Task CreateSubscriber(SubscribeFormModel subscribeFormModel)
    {
        _context.Subscribers.Add(new SubscribeFormEntity { Email = subscribeFormModel.Email });
        await _context.SaveChangesAsync();
    }

}
