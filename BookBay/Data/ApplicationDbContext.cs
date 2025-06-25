using BookBay.Models;
using Microsoft.EntityFrameworkCore;

namespace BookBay.Data
{
    public class ApplicationDbContext:DbContext     {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        // Define DbSets for your entities here, e.g.:
        public DbSet<Category> Categories { get; set; }
        // public DbSet<User> Users { get; set; }
        // public DbSet<Order> Orders { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                  new Category { Id = 3, Name = "History ", DisplayOrder = 3 });
                 // Assuming Category has an Id property
            base.OnModelCreating(modelBuilder);
            // Configure entity relationships and properties here if needed
        }
    }
    
}
