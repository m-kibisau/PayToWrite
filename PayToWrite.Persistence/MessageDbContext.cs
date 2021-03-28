using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using PayToWrite.Domain;

namespace PayToWrite.Persistence
{
    public class MessageDbContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Chat> Chats { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Message> Messages { get; set; }

        public MessageDbContext(DbContextOptions<MessageDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasKey(u => u.ID);

            modelBuilder.Entity<Chat>()
                .HasKey(с => с.ID);

            modelBuilder.Entity<Message>()
                .HasKey(m => m.ID);

            modelBuilder.Entity<Contact>()
                .HasKey(c => c.ID);

            modelBuilder.Entity<Member>()
                .HasKey(m => m.ID);


            modelBuilder.Entity<User>()
                .HasMany(u => u.Contacts)
                .WithOne(c => c.Users)
                .HasForeignKey(c => c.User1)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<User>()
                .HasMany(u => u.Contacts1)
                .WithOne(c => c.Users1)
                .HasForeignKey(c => c.User2)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Chats)
                .WithOne(c => c.Users)
                .HasForeignKey(c => c.Creator)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Messages)
                .WithOne(m => m.Users)
                .HasForeignKey(m => m.Autor)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Members)
                .WithOne(m => m.Users)
                .HasForeignKey(m => m.User_Login)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Chat>()
                .HasMany(c => c.Members)
                .WithOne(m => m.Chats)
                //.HasForeignKey(m => m.ChatID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Chat>()
                .HasMany(c => c.Messages)
                .WithOne(m => m.Chats)
                //.HasForeignKey(m => m.ChatID)
                .OnDelete(DeleteBehavior.NoAction);


        }
    }
}
