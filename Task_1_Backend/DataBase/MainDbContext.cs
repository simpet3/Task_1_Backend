using Microsoft.EntityFrameworkCore;
using Task_1_Backend.Models;

namespace Task_1_Backend.DataBase
{
    public class MainDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public MainDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().HasMany(p => p.Comments).WithOne(c => c.Post).HasForeignKey(c => c.PostId);
            base.OnModelCreating(modelBuilder);
        }
    }
}