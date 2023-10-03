using Crito.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Crito.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<ContactFormEntity> ContactUs { get; set; }
        public DbSet<SubscribeFormEntity> Subscribers { get; set; }
    }
}
