using Microsoft.EntityFrameworkCore;
using RedditBackend.Models;

namespace RedditBackend.Entities
{
    public class RedditContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }

        public RedditContext(DbContextOptions<RedditContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(x=>x.Posts)
                .WithOne(x=>x.Owner);
        }
    }
}
