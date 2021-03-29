using Microsoft.EntityFrameworkCore;

namespace EF_Book_PartyInvites.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<GuestResponse> Responses { get; set; }
    }
}
