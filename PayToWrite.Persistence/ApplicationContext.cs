using Microsoft.EntityFrameworkCore;
using PayToWrite.Domain;

namespace PayToWrite.Persistence
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Contacts> Contacts { get; set; }
        public DbSet<Chats> Chats { get; set; }
        public DbSet<Members> Members { get; set; }
        public DbSet<Messages> Messages { get; set; }
    }
}
